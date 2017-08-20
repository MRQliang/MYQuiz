using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class RegisteredPage : ContentPage
	{
		public RegisteredPage()
		{
			InitializeComponent();
		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MainQuizPage());
		}
	}
}
