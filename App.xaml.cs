using Xamarin.Forms;

namespace MYQuiz
{
	public partial class App : Application
	{
		static AMdatabase database;
		static UserDatabaseController userDatabase;
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
		public static UserDatabaseController UserDatabase
		{
			get
			{
				if (userDatabase == null)
				{
					userDatabase = new UserDatabaseController();

				}
				return userDatabase;
			}
		}
		public static AMdatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new AMdatabase(DependencyService.Get<helper>().GetLocalFilePath("Answerandmark.db3"));

				}
				return database;
			}
				}
	}
}
