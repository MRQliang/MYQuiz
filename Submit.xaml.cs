
using Xamarin.Forms;

namespace MYQuiz
{
	public partial class Submit : ContentPage
	{
		public Submit()
		{
			InitializeComponent();

		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Finally());
		}
	}
}
