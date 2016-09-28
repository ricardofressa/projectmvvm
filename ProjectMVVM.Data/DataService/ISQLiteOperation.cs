using System;
using System.Collections.Generic;
using ProjectMVVM.Entity;

namespace ProjectMVVM.Data
{
	public interface ISQLiteOperation
	{
		void Save(Person person);
		void Remove(Person person);
		void Update(Person person);
		IList<Person> Select();
	}
}
