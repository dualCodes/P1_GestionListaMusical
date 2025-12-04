using NAudio.Wave;
using P1_GestionListaMusical.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_GestionListaMusical.Servicios
{
    internal class AudioPlayerService
    {
        private readonly HorarioRepository _repository = new HorarioRepository();
        private AudioFileReader _audioFile;
        private WaveOutEvent _outputDevice;

        public bool IsPlaying => _outputDevice?.PlaybackState == PlaybackState.Playing;

        public void ReproducirLista(int listaId)
        {
            var rutasAudio = _repository.ObtenerRutasAudioPorLista(listaId);

            if (rutasAudio.Any() && File.Exists(rutasAudio.First()))
            {
                DetenerReproduccion();

                string ruta = rutasAudio.First();

                _outputDevice = new WaveOutEvent();
                _audioFile = new AudioFileReader(ruta);

                _outputDevice.Init(_audioFile);
                _outputDevice.Play();

                _outputDevice.PlaybackStopped += (sender, e) => DetenerReproduccion();

            }
        }

        public void DetenerReproduccion()
        {
            if (_outputDevice != null)
            {
                _outputDevice.Stop();
                _outputDevice.Dispose();
                _outputDevice = null;
            }
            if (_audioFile != null)
            {
                _audioFile.Dispose();
                _audioFile = null;
            }
        }
    }
}
