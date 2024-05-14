using System;
using System.Text;

namespace JintTest
{
	public class JSEncoder
	{
		public JSEncoder()
		{

		}
		string encode(string str)
		{
			return Encoding.ASCII.GetString(Convert.FromBase64String(str));
		}
	}

	public class JSDecoder
	{
		public JSDecoder(string label = "", Options? options = null)
		{

		}
		string decode(byte[] buffer, Options? options = null)
		{
			return System.Text.Encoding.UTF8.GetString(buffer);
		}
	}

	public class Options
	{
		public bool Fatal { get; set; } = false;
		public bool IgnoreBOM { get; set; } = false;
	}

	public class Windows
	{
		static void addEventListener(string input, Action func)
		{
			
		}
	}

	public class Logger
	{
		void log(string m)
		{
			Console.WriteLine($"Message=> {m}");
		}
	}
}

