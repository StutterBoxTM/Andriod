
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ToDoList
{
	[Activity (Label = "DataBaseManager")]			
	public class DataBaseManager : Activity
	{

		static string dbName = "ToDoList.sqlite";
		string dbPath = Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString(), dbName);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here


		}
		public List<ToDO> ViewAllNotes()
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath))
				{
					var cmd = new SQLite.SQLiteCommand (conn);
					var NoteList = cmd.ExecuteQuery<ToDO> ();
					return NoteList;
				}
			} catch(Exception e) 
			{
				Console.WriteLine ("Error: " + e.Message);
				return null;
			}
		}
	}
}

