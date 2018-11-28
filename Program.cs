using System;
using System.Collections.Generic;

namespace csExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();

            bool ending = true;
            System.Console.WriteLine("Add your friends");
            while ( ending == true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) == true)
                {
                    ending = false;
                    break;
                }
                else 
                {
                    friends.Add(input);
                    continue;
                }

            }
            System.Console.WriteLine("Your friends are");
            System.Console.WriteLine(friends[0]+ ", " + friends[1] + " and " + (friends.Count -2) + " other friends");
        }
    }
}
