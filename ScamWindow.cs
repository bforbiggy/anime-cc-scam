using System.Windows;

namespace anime_cc_scam {
	/// <summary>
	/// Interaction logic for ScamWindow.xaml
	/// </summary>
	public partial class ScamWindow : Window {
		public ScamWindow() {
			InitializeComponent();
		}

		private void ScamWindowLoaded(object sender, RoutedEventArgs e) {
			var window = Window.GetWindow(this);
			//window.KeyDown += HandleKeyPress;
		}

		private void OnSubmit() {

		}
	}
}
