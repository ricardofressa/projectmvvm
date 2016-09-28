using System;
using SQLite;

namespace ProjectMVVM.Data
{
	public interface ISQLite
	{
		SQLiteConnection GetCoonection();
	}
}
