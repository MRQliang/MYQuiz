using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class QuizPage : ContentPage
	{
		public QuizPage()
		{
			InitializeComponent();
		}


		void Handle_ClickedQ1A(object sender, System.EventArgs e)
		{
			a1.Text = "true";
		}
		void Handle_ClickedQ1B(object sender, System.EventArgs e)
		{
			a1.Text = "false";
		}


		void Handle_ClickedQ2A(object sender, System.EventArgs e)
		{
			a2.Text = "5";
		}
		void Handle_ClickedQ2B(object sender, System.EventArgs e)
		{
			a2.Text = "6";
		}
		void Handle_ClickedQ2C(object sender, System.EventArgs e)
		{
			a2.Text = "7";
		}

		void Handle_ClickedQ3A(object sender, System.EventArgs e)
		{
			a3.Text = "Darwin";
		}
		void Handle_ClickedQ3B(object sender, System.EventArgs e)
		{
			a3.Text = "Melboune";
		}
		void Handle_ClickedQ3C(object sender, System.EventArgs e)
		{
			a3.Text = "Sydney";
		}
		void Handle_ClickedQ3D(object sender, System.EventArgs e)
		{
			a3.Text = "Canberra";
		}


		async void SAVE_Clicked(object sender, System.EventArgs e)
		{	
			
			Answerandmark answerItem = new Answerandmark(a1.Text, a2.Text, a3.Text, a4.Text, a5.Text);
			await App.Database.SaveAnswerandmarkAsync(answerItem);
			await Navigation.PopAsync();
			answerItem.CheckAnswer();
		}

		void Check_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Submit());
		}
	}
}
