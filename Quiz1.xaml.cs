using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class Quiz1 : ContentPage
	{
		public Quiz1()
		{
			InitializeComponent();


		}
		public int m1;
		public string q1="";
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			q1= "ture"; m1 = 2;
		}
		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			q1= "false"; m1= 0;
		}
	}
}
