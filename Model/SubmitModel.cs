using System;

namespace MYQuiz
{
	public class SubmitModel
	{
		Model _Model;

		public Model Model
		{
			get { return _Model; }
			set { _Model = value; }

		}


		public SubmitModel()
		{
			Model = new Model

			{
				q1 = "1",
				q2 = "2",
				q3 = "3",
				q4 = "4",
				q5 = "5",
			};
		}

	}
}
