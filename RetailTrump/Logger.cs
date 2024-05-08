using System;
using System.IO;
using System.Text;

namespace RetailTrump
{
	internal static class Logger
	{
		public static void Log(string e)
		{
			using StreamWriter streamWriter = new StreamWriter("ErrorLog.log", append: true, Encoding.GetEncoding("ISO-8859-1"));
			streamWriter.WriteLine($"{DateTime.Now} {e}");
			streamWriter.Close();
		}

		public static void LogStart()
		{
			using StreamWriter streamWriter = new StreamWriter("ErrorLog.log", append: true, Encoding.GetEncoding("ISO-8859-1"));
			streamWriter.WriteLine($"{DateTime.Now} ********** App Start **********");
			streamWriter.Close();
		}

		public static void LogEnd()
		{
			using StreamWriter streamWriter = new StreamWriter("ErrorLog.log", append: true, Encoding.GetEncoding("ISO-8859-1"));
			streamWriter.WriteLine($"{DateTime.Now} ********** App Closed ********** \n\n\n");
			streamWriter.Close();
		}
	}
}
