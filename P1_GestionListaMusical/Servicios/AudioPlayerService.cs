using NAudio.Wave;
using P1_GestionListaMusical.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P1_GestionListaMusical.Servicios
{
    public class AudioPlayerService : IDisposable
    {
        private IWavePlayer _waveOut;
        private AudioFileReader _audioFileReader;
        private readonly HorarioRepository _repo = new HorarioRepository();
        private Queue<string> _playQueue = new Queue<string>();
        public bool IsPlaying { get; private set; }

        public void ReproducirLista(int listaId)
        {
            DetenerReproduccion();

            var rutas = _repo.ObtenerRutasAudioPorLista(listaId);
            if (rutas == null || rutas.Count == 0) return;

            _playQueue = new Queue<string>(rutas);

            ReproducirSiguiente();
        }

        private void ReproducirSiguiente()
        {
            if (_playQueue.Count == 0)
            {
                IsPlaying = false;
                return;
            }

            string ruta = _playQueue.Dequeue();

            if (!File.Exists(ruta))
            {
                ReproducirSiguiente();
                return;
            }

            try
            {
                if (_waveOut != null)
                {
                    _waveOut.Stop();
                    _waveOut.Dispose();
                    _waveOut = null;
                }

                if (_audioFileReader != null)
                {
                    _audioFileReader.Dispose();
                    _audioFileReader = null;
                }

                _waveOut = new WaveOutEvent();
                _audioFileReader = new AudioFileReader(ruta);

                _waveOut.Init(_audioFileReader);

                _waveOut.PlaybackStopped += (s, e) =>
                {
                    ReproducirSiguiente();
                };

                _waveOut.Play();
                IsPlaying = true;
            }
            catch
            {
                IsPlaying = false;
            }
        }

        public void DetenerReproduccion()
        {
            IsPlaying = false;
            _playQueue.Clear();

            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOut.Dispose();
                _waveOut = null;
            }
            if (_audioFileReader != null)
            {
                _audioFileReader.Dispose();
                _audioFileReader = null;
            }
        }

        public void Dispose()
        {
            DetenerReproduccion();
        }
    }
}