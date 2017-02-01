using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class ListManagerBrain
    {
        //NOTE: no need to go static here. It's actually anti-pattern here. You want to instantiate an instance of class in main app (with `new`) 
        // if you have static here, all the instances of LMB will share the same list (doesn't seem sensible)
        static List <string> theList = new List<string>();
        
        //note: those shouldn't be static
     public static void AddItemToList()
     {
         
         theList.Add(Console.ReadLine());
     }
     
     public static void RemoveItemFromList()
     {
      
      theList.Remove(Console.ReadLine());  
     }
     
     public static void ClearList()
     {
      theList.Clear();   
     }
     
     public static void ViewList()
     {
      foreach (var listItem in theList)
       {
          Console.WriteLine(listItem);
       }
       }
       
        //Note: call from Add/Remove/Clear methods and make static. Also, don't use Console.ReadLIne() here, but pass the parameters.
       public static void ListItemChangeNotification() 
       {
          if (Console.ReadLine() == "1")
          {
           Console.WriteLine("An item has been added to your list!");  
          } 
          
          else if (Console.ReadLine() == "4")
          {
           Console.WriteLine("An item has been removed from your list!");   
          }
          else if (Console.ReadLine() == "3")
          {
           Console.WriteLine("Your list has been cleared!");   
          }
       }
           
       
          }
    }

