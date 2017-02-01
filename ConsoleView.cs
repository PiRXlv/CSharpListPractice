using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class App
    {
        public static void Main() {
        //note: wrong order of statements - you ain't getting output till you enter something
        string userAction = Console.ReadLine();
        MainMenu.displayMenu();
        
        //note: Do-while probably is better suited than while for this
        // also - you are stuck on loop here as you don't re-assign userAction
        while (userAction != "5") 
        {
          MainMenu.displayMenu();
          
            //note: this probably should be saved in variable and switch statement used instead of blocks of if/else
            // also no need to call MainMenu.displayMenu() here
          if (Console.ReadLine() == "1")
          { 
          ListManagerBrain.AddItemToList();
        // note: calling ItemChangeNotification belongs to LIstManagerBrainLogic instead of MainApp
          ListManagerBrain.ListItemChangeNotification();
          MainMenu.displayMenu();
          }
        
        
        else if (Console.ReadLine() == "2") 
        {
           ListManagerBrain.RemoveItemFromList(); 
           ListManagerBrain.ListItemChangeNotification();
           MainMenu.displayMenu();
        }
        
        else if (Console.ReadLine() == "3") 
        {
          ListManagerBrain.ClearList();
          MainMenu.displayMenu();  
        }
        
        else if (Console.ReadLine() == "4")
        {
         ListManagerBrain.ViewList();   
        }
       
            }
        }
    }
}
