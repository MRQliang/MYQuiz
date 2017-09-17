using System;
using SQLite;

namespace MYQuiz
{
	public class Token
	{	[PrimaryKey]
		public int Id  { get; set; }
		public string access_token { get; set;}
		public string error_token { get; set;}
		public DateTime expire_date { get; set;}

		public Token() { }

	}
}
