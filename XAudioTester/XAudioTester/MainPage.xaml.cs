using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace XAudioTester {
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        private void Button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) {
            XPlayer.Instance.PlayWave(0);
        }

        private void Button_Tapped_1(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e) {
            XPlayer.Instance.PlayWave(1);
        }
    }
}
