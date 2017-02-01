using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class App
    {
        public static void Main() {
        
        string userAction = Console.ReadLine();
        MainMenu.displayMenu();
        
        while (userAction != "5") 
        {
          MainMenu.displayMenu();
          
          if (Console.ReadLine() == "1")
          { 
          ListManagerBrain.AddItemToList();
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
