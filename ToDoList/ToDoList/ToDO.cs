using System;
using SQLite;

namespace ToDoList
{
	public class ToDO
	{

			[PrimaryKey, AutoIncrement]
			public int ListID {get; set; }
			public string Title {get; set; }
			public string Details {get; set; }
			public DateTime Date {get; set; }

		public ToDO ()
		{

		}

	}
}

