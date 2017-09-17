using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MYQuiz
{
	public partial class MainQuizPage : MasterDetailPage
	{
		public MainQuizPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			IsPresented = true;

		}

	void Handle_ClickedS(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Quiz1());
		}
	void Handle_Clicked2(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Quiz2());
		}
	void Handle_Clicked3(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Quiz3());
		}
	void Handle_Clicked4(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Quiz4());
		}
	void Handle_Clicked5(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Quiz5());
		}
	void Handle_Clicked6(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Submit());
		}
	}
}
