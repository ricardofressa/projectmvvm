using System;
using SQLite;

namespace ProjectMVVM.Entity
{
	[Table("Person")]
	public class Person : EntityBase
	{
		private string _name;
		private string _email;
		private string _address;

		public Person()
		{
		}

		[Column("Id")]
		[AutoIncrement, PrimaryKey]
		public int Id { get; set; }

		[Column("Name")]
		[MaxLength(150)]
		public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				RaisedPropertyChanged(() => Name);
			}
				
		}

		[Column("Email")]
		[MaxLength(100)]
		public string Email
		{ 
			get 
			{ 
				return _email; 
			} 
			set
			{
				_email = value;
				RaisedPropertyChanged(() => Email);
			}
		}

		[Column("Address")]
		[MaxLength(200)]
		public string Address 
		{ 
			get
			{
				return _address;
			}
			set
			{
				_address = value;
				RaisedPropertyChanged(() => Address);
			}
		}
}
