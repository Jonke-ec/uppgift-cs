using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager {
    internal class MenuHandler {
        public int MainMenu(string input = "") {

            try {
                Console.WriteLine("[1] Lägg Till Kund");
                Console.WriteLine("[2] Se kunder");
                Console.WriteLine("[3] Hämta Rabatkod");
                Console.WriteLine("[4] Ta bort Kund");

                if (input != "")
                    return int.Parse(input);
                return int.Parse(Console.ReadLine() ?? "-1");
            }
            catch {
                return -1;
            }
        }

    }
}
