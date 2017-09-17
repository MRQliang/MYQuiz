using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MYQuiz
{
	public interface ISQlite
	{
		SQLiteConnection GetConnection();
	}
}
