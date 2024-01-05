using NAudio.Wave; 

namespace ThreadsApp
{
    /// <summary>
    /// Represents a music player that sues NAudio for playback.
    /// </summary>
    internal class MusicPlayer
    {
        #region FIELDS
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        #endregion

        #region PROPERTIES
        public string Song { get; set; }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the MusicPlayer class.
        /// </summary>
        /// <param name="song">The path to the song file.</param>
        public MusicPlayer(string song)
        {
            this.Song = song;
            audioFileReader = new AudioFileReader(song);
            waveOutEvent = new WaveOutEvent();
            waveOutEvent.Init(audioFileReader);
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Plays the loaded song using the NAudio library.
        /// </summary>
        public void Play()
        {
            if (!string.IsNullOrEmpty(Song))
            {
                if (waveOutEvent.PlaybackState == PlaybackState.Stopped)
                {
                    waveOutEvent.Init(audioFileReader);
                }

                waveOutEvent.Play();
            }
        }

        /// <summary>
        /// Stops the playback of the song. 
        /// </summary>
        public void Stop()
        {
            if (waveOutEvent.PlaybackState != PlaybackState.Stopped)
            {
                waveOutEvent.Stop();
            }
        }

        /// <summary>
        /// Disposes of the resources used by the music player.
        /// </summary>
        public void Dispose()
        {
            waveOutEvent?.Dispose();
            audioFileReader?.Dispose();
        }
        #endregion
    }
}
