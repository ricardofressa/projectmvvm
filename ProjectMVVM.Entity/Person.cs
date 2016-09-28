using System;
using SQLite;

namespace ProjectMVVM.Entity
{
	[Table("Person")]
	public class Person
	{
		public Person()
		{
		}

		[Column("Id")]
		[AutoIncrement, PrimaryKey]
		public int Id { get; set; }

		[Column("Nome")]
		[MaxLength(150)]
		public string Nome { get; set; }

		[Column("Email")]
		[MaxLength(100)]
		public string Email { get; set; }

		[Column("Endereco")]
		[MaxLength(200)]
		public string Endereco { get; set;}

	}
}
