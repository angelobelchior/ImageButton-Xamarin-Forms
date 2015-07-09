using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyImageButton
{
	public class ViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		string texto;
		public string Texto {
			get {
				return texto;
			}
			set {
				texto = value;this.Notify ("Texto");
			}
		}

		public ICommand ToqueCommand {
			get;
			set;
		}

		public ViewModel ()
		{
			this.ToqueCommand = new Command (this.Toque);
		}

		private int i = 0;
		private void Toque(object parameter)
		{
			this.Texto = string.Format ("Toque número {0}", i++);
		}

		private void Notify(string parameter)
		{
			if (this.PropertyChanged != null) {
				this.PropertyChanged (this, new PropertyChangedEventArgs(parameter));
			}
		}
	}
}

