using System;

using Xamarin.Forms;

namespace MYQuiz
{
	public class RegisteredPageModel 
	{
		
			Model _Model;

			public Model Model
			{
			get { return _Model; }
			set { _Model = value; }

			}
		public RegisteredPageModel() 
		{
			Model = new Model
			{
				username = "",
				password = ""
			};
		}
		}
	}


