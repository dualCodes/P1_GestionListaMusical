using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

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
                // Verificamos cada segundo para mayor precisión
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

            // Evitamos ejecución múltiple en el mismo segundo/minuto para el mismo evento
            if (now.Second != 0) return;

            try
            {
                // Reiniciar el ID ejecutado si cambiamos de minuto para permitir otros eventos
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

                        // Solo permitimos disparar un evento por segundo exacto para evitar conflictos de audio
                        break;
                    }
                }
            }
            catch (Exception)
            {
                // Loguear error si existe mecanismo, si no, silenciar para no detener el servicio
            }
        }

        private bool EsMomentoDeEjecutar(Horario horario, DateTime fechaActual)
        {
            // Normalizamos segundos para comparar
            var inicio = horario.InicioRegla;

            // CASO 1: Evento Único (Sin Regla)
            // Debe coincidir Fecha exacta, Hora y Minuto
            if (string.IsNullOrWhiteSpace(horario.ReglaRRule))
            {
                return inicio.Year == fechaActual.Year &&
                       inicio.Month == fechaActual.Month &&
                       inicio.Day == fechaActual.Day &&
                       inicio.Hour == fechaActual.Hour &&
                       inicio.Minute == fechaActual.Minute;
            }

            // CASO 2: Repetir Diario (FREQ=DAILY)
            // Ignoramos la fecha, solo importa que coincida Hora y Minuto
            if (horario.ReglaRRule.ToUpper().Contains("FREQ=DAILY"))
            {
                return inicio.Hour == fechaActual.Hour &&
                       inicio.Minute == fechaActual.Minute;
            }

            // CASO 3: Otros casos complejos (Semanal, Mensual) - Implementación básica
            // Si necesitas soporte real para reglas complejas (ej. "Solo Lunes"), 
            // aquí es donde intentaríamos usar Ical.Net, pero por ahora devolvemos false 
            // para asegurar estabilidad en lo básico.
            return false;
        }
    }
}