using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyImageButton
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();
			this.BindingContext = new ViewModel ();
		}
	}
}