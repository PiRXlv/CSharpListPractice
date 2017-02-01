using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class MainMenu
    {
        //note: not sure it warrants seperate class for it - I would put it in listmanager, as it's logically connected - available actions are 
        // determined by list manager. Now you have to change two files when functionality changes
        public static void displayMenu() 
        {
            //note: you could have used multiline string here (@"contents")
            Console.WriteLine("LIST MANAGER!");
            Console.WriteLine();
            Console.WriteLine("Type (1) to add an item to your list.");
            Console.WriteLine("Type (2)) to remove an item from your list.");
            Console.WriteLine("Type (3) to clear your list.");
            Console.WriteLine("Type (4) to view your list.");
            Console.WriteLine("Type (5) to exit the program.");
            
        }
    }
}
