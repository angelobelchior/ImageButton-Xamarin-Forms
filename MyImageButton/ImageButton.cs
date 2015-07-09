using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace MyImageButton
{
	public class ImageButton : Image
	{
		public static BindableProperty CommandProperty = 
			BindableProperty.Create<ImageButton, ICommand> (bp => bp.Command, default(ICommand));

		public ICommand Command {
			get{ return (ICommand)this.GetValue (CommandProperty); }
			set{ this.SetValue (CommandProperty, value); }
		}

		public ImageButton ()
		{
			var gesto = new TapGestureRecognizer ();
			gesto.Tapped += (sender, e) => {
				if(this.Command != null && this.Command.CanExecute(null))
				{
					this.Command.Execute(null);
				}
			};

			this.GestureRecognizers.Add (gesto);
		}
	}
}