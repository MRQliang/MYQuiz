using System;
using SQLite;
namespace MYQuiz
{
	public class Answerandmark
	{	
		[PrimaryKey,AutoIncrement]
		public int AMId	{ get; set;}
		public string A1 { get; set;}
		public string A2 { get; set;}
		public string A3 { get; set;}
		public string A4 { get; set;}
		public string A5 { get; set;}
		public int _mark = 0;
		public int mark1;
		public int mark2;
		public int mark3;
		public int mark4;

		public int mark { get; set;}




		public bool CheckAnswer()
		{
			if (this.A1.Equals("true"))
			{
				mark1 = _mark + 2;
			}
			else if(this.A2.Equals("6"))
			{
				mark2 = mark1 + 2;
			}
			else if(this.A3.Equals("Canberra"))
			{
				mark3 = mark2 + 2;
			}
			else if (this.A4.Equals("Melbourne") || this.A4.Equals("Mel") || this.A4.Equals("melboune")|| this.A4.Equals("mel")
			    || this.A4.Equals("MEL"))
			{
				mark4 = mark3 + 2;
			}
			else if (this.A5.Equals("Sydeny")|| this.A5.Equals("sydney")||this.A5.Equals("SYD")|| this.A5.Equals("syd")
			    || this.A5.Equals("Syd"))
			{
				mark = mark4 + 2;
			}
			else
			{
				mark = _mark + 0;
			}



		
		
	}
}
