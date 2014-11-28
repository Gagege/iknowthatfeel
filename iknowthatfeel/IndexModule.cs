using System;
using Nancy;

namespace iknowthatfeel
{
	public class IndexModule : Nancy.NancyModule
	{
		public IndexModule ()
		{
			Get["/"] = _ => "Hello World";
		}
	}
}

