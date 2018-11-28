using System;
using System.Collections.Generic;
using System.Linq;

namespace csExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var friends = new List<string>();

            // bool ending = true;
            // System.Console.WriteLine("Add your friends");
            // while ( ending == true)
            // {
            //     var input = Console.ReadLine();
            //     if (string.IsNullOrEmpty(input) == true)
            //     {
            //         ending = false;
            //         break;
            //     }
            //     else 
            //     {
            //         friends.Add(input);
            //         continue;
            //     }

            // }
            // System.Console.WriteLine("Your friends are");
            // System.Console.WriteLine(friends[0]+ ", " + friends[1] + " and " + (friends.Count -2) + " other friends");
            
            // System.Console.WriteLine("I will reverse a string");
            // string name = Console.ReadLine();
            // char[] nameReverse = name.ToCharArray();
            // Array.Reverse(nameReverse);
            // System.Console.WriteLine();
            // foreach (var u in nameReverse)
            //     System.Console.Write(u);
            // System.Console.WriteLine();

            // System.Console.WriteLine("Enter 5 numbers");
            // int[] five = new int[5];
            // for (int i = 0; i <= five.Length - 1; i++)
            // {
            //     var num = Convert.ToInt32(Console.ReadLine());
            //     foreach(var u in five)
            //     {
            //         if(num == u)
            //         {
            //             System.Console.WriteLine("dublicate number entered. Enter new one"); 
            //             i--; 
            //             break;   
            //         }               
            //     }
            //     five[i] = num;
            // }
            // Array.Sort(five);
            //     foreach(var item in five)
            //     {
            //         Console.Write(item.ToString());
            //     }
            //     System.Console.WriteLine();

        //     System.Console.WriteLine("Enter numbers enter quit to stop");
        //     bool thing = true;
        //     var numbers = new List<int>();
        //     while(thing == true)
        //     {
        //         var number = Console.ReadLine();
        //         if(number == "quit")
        //         {
        //             thing = false;
        //         } 
        //         else
        //         {
        //             numbers.Add(Convert.ToInt32(number));
        //         }
        //     }
        //     List<int>distinct = numbers.Distinct().ToList();
        //     foreach ( var i in distinct)
        //         System.Console.Write(i);
        // Console.WriteLine();

        Console.Write("Enter comma separated numbers (more than 5)");
        var palladin = true;
        var userinput = "";
        var nums = userinput.Split(',');
        while(palladin == true)
        {
        userinput = Console.ReadLine();
        nums = userinput.Split(',');
            if(nums.Length < 5)
            {
                System.Console.WriteLine("less than 5");
            } else 
                palladin = false;
        }
        Array.Sort(nums);
        for(var i = 0; i < 3; i++)
        {
            System.Console.WriteLine(nums[i]);
        }
        }
    }
}
