using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class ListManagerBrain
    {
        static List <string> theList = new List<string>();
        
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

