﻿using System;
using System.Collections.Generic;

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

            System.Console.WriteLine("Enter 5 numbers");
            int[] five = new int[5];
            for (int i = 0; i <= five.Length - 1; i++)
            {
                var num = Convert.ToInt32(Console.ReadLine());
                foreach(var u in five)
                {
                    if(num == u)
                    {
                        System.Console.WriteLine("dublicate number entered. Enter new one"); 
                        i--; 
                        break;   
                    }               
                }
                five[i] = num;
            }
            Array.Sort(five);
                foreach(var item in five)
                {
                    Console.Write(item.ToString());
                }
                System.Console.WriteLine();
        }
    }
}
