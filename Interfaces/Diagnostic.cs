using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	class Diagnostic : IPrint {

		public void Print(string s) {
			System.Diagnostics.Debug.WriteLine(s); //this writes to the "Output" tab below when running in Debugging mode (F5)
		}

		public void PrintAll(string[] strings) {
			foreach(string str in strings) {
				Print(str);
			}
		}

		public Diagnostic() { }
	}
}
