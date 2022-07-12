using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
	}
}
