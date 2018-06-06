using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	class Console : IPrint, IWrite { //note that this is the way to inherit multiple interfaces...with a comma ","

		public void Print(string s) {
			System.Console.WriteLine(s);
		}

		public void PrintAll(string[] strings) {
			foreach(string str in strings) {
				Print(str); //uses the print method above
			}
		}

		public void Write(string s) {
			throw new NotImplementedException();
		}

		public Console() { }
	}
}
