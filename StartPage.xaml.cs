using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			InitializeComponent();
		}

		void Start(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new QuizPage());
		}
	}
}
