using System;
using System.Threading.Tasks;
using XAudioPlayer;

namespace XAudioTester {
    public class XPlayer : IDisposable {
        private XAudio2SoundPlayer player;

        private static XPlayer instance;
        public static XPlayer Instance {
            get {
                if (instance == null) {
                    instance = new XPlayer();
                }
                return instance;
            }
        }

        public XPlayer() {
            player = new XAudio2SoundPlayer();
            var audioCount = player.LoadSounds();

        }

        public void PlayWave(uint index) {
            player.PlaySound(index);
        }

        public void Dispose() {
        }
    }
}