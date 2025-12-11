using System;
using System.Collections.Generic;
using System.Linq;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;

namespace P1_GestionListaMusical.Servicios
{
    public class SchedulerService
    {
        private System.Timers.Timer _timer;
        private readonly AudioPlayerService _playerService = new AudioPlayerService();
        private int _lastExecutedEventId = -1;
        private DateTime _lastExecutionTime = DateTime.MinValue;
        private bool _isStopping = false;

        public void Iniciar()
        {
            _isStopping = false;

            if (_timer == null)
            {
                _timer = new System.Timers.Timer(1000);
                _timer.Elapsed += VerificarHorarios;
                _timer.AutoReset = true;
            }

            _timer.Start();
        }

        public void Detener()
        {
            _isStopping = true;

            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }

            try
            {
                _playerService.DetenerReproduccion();
            }
            catch { }
        }

        private void VerificarHorarios(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_isStopping || _timer == null) return;

            var now = DateTime.Now;

            if (now.Second != 0) return;

            try
            {
                if (_lastExecutionTime.Minute != now.Minute)
                {
                    _lastExecutedEventId = -1;
                }

                var horariosActivos = new HorarioRepository().ObtenerHorariosActivos();

                foreach (var horario in horariosActivos)
                {
                    if (_isStopping) break;

                    if (horario.EventoID == _lastExecutedEventId) continue;

                    if (EsMomentoDeEjecutar(horario, now))
                    {
                        _playerService.ReproducirLista(horario.ListaID);
                        _lastExecutedEventId = horario.EventoID;
                        _lastExecutionTime = now;
                        break;
                    }
                }
            }
            catch { }
        }

        private bool EsMomentoDeEjecutar(Horario horario, DateTime fechaActual)
        {
            var inicioLocal = DateTime.SpecifyKind(horario.InicioRegla, DateTimeKind.Local);

            if (string.IsNullOrWhiteSpace(horario.ReglaRRule))
            {
                return inicioLocal.Date == fechaActual.Date &&
                       inicioLocal.Hour == fechaActual.Hour &&
                       inicioLocal.Minute == fechaActual.Minute;
            }

            try
            {
                var vEvent = new CalendarEvent
                {
                    Start = new CalDateTime(inicioLocal)
                };

                var pattern = new RecurrencePattern(horario.ReglaRRule);
                vEvent.RecurrenceRules.Add(pattern);

                var searchStart = new CalDateTime(fechaActual.Date);
                var occurrences = vEvent.GetOccurrences(searchStart);

                foreach (var occurrence in occurrences)
                {
                    var occTime = occurrence.Period.StartTime.Value;

                    if (occTime.Kind == DateTimeKind.Utc)
                    {
                        occTime = occTime.ToLocalTime();
                    }

                    if (occTime.Date == fechaActual.Date &&
                        occTime.Hour == fechaActual.Hour &&
                        occTime.Minute == fechaActual.Minute)
                    {
                        return true;
                    }

                    if (occTime > fechaActual)
                    {
                        break;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}