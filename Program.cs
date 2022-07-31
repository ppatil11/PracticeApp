using Code.PracticeApp.Interfaces;
using Code.PracticeApp.LinkedList;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.PracticeApp;
public class Program
{
    public static void deepCopy(Person p)
    {        
        var deepCopy = ObjectClonning.CreateDeepCopy<Person>(p);
        Console.WriteLine(p);
        Console.WriteLine(deepCopy);
    }

   

    static void Main(string[] args)
    {
        

        Console.WriteLine("Hello, Lets write some C#");
        int[] arr = {0};
        int size = arr.Length;

        //--------------------------------------------       
        string tu = TinyUrlConversion.IdToShortUrl(12345);
        Console.WriteLine("Tiny URL = "+tu);
        int id = TinyUrlConversion.shortURLtoID(tu);
        Console.WriteLine("ID back from tiny url = " + id);
        //--------------------------------------------

        //--------------------------------------------
        NumberFromDecimalRepresentation numberFromDecimal = new();

        int num = numberFromDecimal.GetNumberFromDecimalArray(arr);
        Console.WriteLine("Number created from Decimal represenatation array = " + num);
        //--------------------------------------------

        Solution sol = new Solution();

        

        int number = 0;
        string tempNum = "";

        for (int i = size - 1; i >= 0; i--)
        {
            tempNum = tempNum + arr[i].ToString();
        }

        // return number;

        number = Int32.Parse(tempNum);


        int result = sol.solutions(arr);
                
        Console.WriteLine("The smallest positive missing number is " + number);


        //    Person bob = new("Bob", 21);
        //    deepCopy(bob);

       // HashSet hashSet = new();
       // var hs = hashSet.Get();
       // hashSet.ReadAll(hs);
       // hashSet.Read(hs, "C++");
    
    SingleLinkedList singleLinkedList = new SingleLinkedList();
    var lis =  singleLinkedList.InsertFront(singleLinkedList, 1);
        lis = singleLinkedList.InsertFront(lis, 2);
        lis = singleLinkedList.InsertFront(lis, 3);
        lis = singleLinkedList.InsertLast(lis, 10);

        Node temp = lis.head;
        while(temp.next != null)
        {
            Console.WriteLine($"SLL : {temp.data}");
            temp = temp.next;
        }
        /*
                var map = new MultiMap<string, IEnumerable<string>>();
                HashSet<string> hs = new();
                hs.Add("a");
                hs.Add("b");

                map.Add("Key1", hs);
                map.Add("Key2", hs);

                foreach(string key in map.Keys)
                {
                   // foreach(string value in map[key])
                  //  {
                   //     Console.WriteLine($"{key} - {value}");
                   // }
                }
          */


    }


}
