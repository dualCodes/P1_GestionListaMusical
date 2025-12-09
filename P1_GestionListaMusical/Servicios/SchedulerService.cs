using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
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

        private List<Horario> ObtenerHorariosActivos()
        {
            var horarios = new List<Horario>();
            string query = "SELECT EventoID, ListaID, Nombre, ReglaRRule, InicioRegla, Excepciones, EstaActivo FROM Horarios WHERE EstaActivo = 1";

            try
            {
                using (var conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horarios.Add(new Horario
                            {
                                EventoID = reader.GetInt32("EventoID"),
                                ListaID = reader.GetInt32("ListaID"),
                                Nombre = reader.GetString("Nombre"),
                                ReglaRRule = reader.IsDBNull(reader.GetOrdinal("ReglaRRule")) ? string.Empty : reader.GetString("ReglaRRule"),
                                InicioRegla = reader.GetDateTime("InicioRegla"),
                                Excepciones = reader.IsDBNull(reader.GetOrdinal("Excepciones")) ? string.Empty : reader.GetString("Excepciones"),
                                EstaActivo = reader.GetBoolean("EstaActivo")
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return horarios;
        }

        private void VerificarHorarios(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_isStopping || _timer == null) return;

            try
            {
                var now = DateTime.Now;

                if (now.Second != 0) return;

                _lastExecutedEventId = -1;

                var horariosActivos = ObtenerHorariosActivos();

                foreach (var horario in horariosActivos)
                {
                    if (_isStopping) break;

                    if (now.Hour == horario.InicioRegla.Hour &&
                        now.Minute == horario.InicioRegla.Minute)
                    {
                        if (EsMomentoDeEjecutar(horario, now))
                        {
                            if (_lastExecutedEventId != horario.EventoID)
                            {
                                _playerService.ReproducirLista(horario.ListaID);
                                _lastExecutedEventId = horario.EventoID;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private bool EsMomentoDeEjecutar(Horario horario, DateTime fechaActual)
        {
            if (string.IsNullOrWhiteSpace(horario.ReglaRRule))
            {
                return true;
            }

            try
            {
                var vEvent = new CalendarEvent
                {
                    Start = new CalDateTime(horario.InicioRegla)
                };

                vEvent.RecurrenceRules.Add(new RecurrencePattern(horario.ReglaRRule));

                var searchStart = new CalDateTime(fechaActual.Date);

                var occurrences = vEvent.GetOccurrences(searchStart);

                foreach (var occ in occurrences)
                {
                    if (occ.Period.StartTime.Value.Date == fechaActual.Date)
                    {
                        return true;
                    }

                    if (occ.Period.StartTime.Value.Date > fechaActual.Date)
                    {
                        break;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}