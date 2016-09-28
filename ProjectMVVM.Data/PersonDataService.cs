using System;
using System.Collections.Generic;
using System.Linq;
using ProjectMVVM.Entity;
using SQLite;

namespace ProjectMVVM.Data
{
	public class PersonDataService : ISQLiteOperation
	{
		private SQLiteConnection _connection;

		public PersonDataService(SQLiteConnection connection)
		{
			//_connection = DependencyService.Get<ISQLite>().GetConnection();
			this._connection = connection;
			_connection.CreateTable<Person>();
		}

		public void Remove(Person person)
		{
			_connection.Delete(person);
		}

		public void Save(Person person)
		{
			_connection.Insert(person);
		}

		public IList<Person> Select()
		{
			return _connection.Table<Person>().ToList();
		}

		public void Update(Person person)
		{
			_connection.Update(person);
		}
	}
}
