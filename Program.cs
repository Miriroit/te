using System;
using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> resList = new List<int>(new int[] { 1, 2, 8, 1, 2, 3, 5, 6, 7, 2, 2, 9, 9, 9, 3, 2, 1, 2, 35 });
            Logic l = new Logic(resList);

            int res = l.getNewPostion(3);
            Console.WriteLine( res);
            


        }
    }
}