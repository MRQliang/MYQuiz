using System;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MYQuiz
{
	public class AMdatabase
	{
		readonly SQLiteAsyncConnection database;
		public AMdatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Answerandmark>().Wait();
		}
		public Task<List<Answerandmark>> GetAnswerandmark()
		{
			return database.Table<Answerandmark>().ToListAsync();
		}
		public Task<List<Answerandmark>> GetAnswerandmark(int id)
		{
			return database.Table<Answerandmark>().Where(i = i.AMId == id).FirstOrDefaultAsync();
		}
		public Task<int> SaveAnswerandmarkAsync(Answerandmark answerandmark)
		{
			if (answerandmark.AMId == 0)
			{
				return database.UpdateAsync(answerandmark);
			}
			else {
				return database.InsertAsync(answerandmark);
			}
		}
		public Task<int> DeleteAnswerandmarkAsync(Answerandmark answerandmark)
		{
			return database.DeleteAsync(answerandmark);
		}
	}
}
