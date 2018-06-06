using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	class Program {
		static void Main(string[] args) {

			//IPrint printer = new Printer(); //any variable put in here has to implement the IPrint method
			//printer.Print("s");
			//note that we cannot do printer.Debug() because it is not in the IPrint interface but rather only exists in the Printer class

			//IEnumerable <int> collection = new int[3];
			//IEnumerable <int> collection2 = new List<int>();

			//IPrint printer = new Console();
			//printer.Print("A single string to the console");

			IPrint printer = new Diagnostic();
			printer.Print("A single string to the output");
			IWrite writer = new Console(); // can only do new Console() here and not new Diagnostic() because Console inherited IWrite and Diagnostic did not inherit IWrite


			//IPrint printer2 = new Diagnostic();

		}
	}
}
