using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    class Game {


        public Game() {
            do {
                //if(Console.ReadKey(true).Key == ConsoleKey.Backspace) {
                //    Screen.ClearScreen();
                //}

                if(Input.KeyDown(ConsoleKey.Spacebar, 0.1f)) {
                    Input.Print("space");
                }
            } while(Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
