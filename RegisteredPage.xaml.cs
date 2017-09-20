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
			Init();
		}

		void Init()
		{
			Entry_Username.Completed += (s, e) => Entry_Password.Focus();
			Entry_Password.Completed += (s, e) => Handle_Clicked2(s, e);
		}

		void Handle_Clicked(object sender, EventArgs e)
		{
			
			Navigation.PushAsync(new MainQuizPage());

		}

		void Handle_Clicked2(object sender, EventArgs e)
		{
			User user = new User(Entry_Username.Text, Entry_Password.Text);
			//get the data to database//
			if (user.CheckInformation())
			{
				DisplayAlert("Registered",
							"Registered successful!",
							"OK");
				App.UserDatabase.SaveUser(user);
			}
			//Display if registered successful//
			else
			{
				DisplayAlert("Registered",
							"Registered Not Correct, empty username or password!",
							"OK");
			}
			//Display if registered Not Correct//
		}
	}
}
