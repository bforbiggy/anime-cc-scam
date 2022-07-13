using System.Windows;
using System.Windows.Controls;

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

		private void OnSubmit(object sender, RoutedEventArgs e) {
			TextBlock text = new TextBlock();
			text.VerticalAlignment = VerticalAlignment.Center;
			text.HorizontalAlignment = HorizontalAlignment.Center;
			text.Text = "wtf?!?!?! down horrendous!?!?!?";
			Content = text;
		}
	}
}
