using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var listClass = new ListClass();

            listClass.FindLength();

            listClass.ExistsS();

            listClass.FindIndexVermont();

            listClass.FindAllFive();

            listClass.RemoveAl();

            // The number of lists has changed because of exclusion by the RemoveAl function
            listClass.FindIndexVermont();

            listClass.ForeachConsole();

            // Only the output will be lowercased, the list itself will not be lowercased
            listClass.ConvertAllString();

            Console.WriteLine();

            listClass.ForeachConsole();
        }
    }

    class ListClass
    {
        List<string> list = new List<string>
        {
            "Alaska", "Alabama", "Colorado", "Delaware", "Georgia", "Iowa", "Kentucky", 
            "Massachusetts", "Maryland", "Minnesota", "Nevada", "Oklahoma", "Pennsylvania", "Tennessee", 
            "Texas", "Utah", "Vermont", "Washington", "Wisconsin", "WestVirginia", "Wyoming", 
        };

        // Extract the states with 7 characters
        public void FindLength()
        {
            var name = list.Find(s => s.Length == 7);
            Console.WriteLine(name);
            Console.WriteLine();
        }

        // There are states with the initial letter S or not
        public void ExistsS()
        {
            var exists = list.Exists(s => s[0] == 'S');
            Console.WriteLine(exists);
            Console.WriteLine();
        }

        // Get the number of stored indexes for Vermont
        public void FindIndexVermont()
        {
            int index = list.FindIndex(s => s == "Vermont");
            Console.WriteLine(index);
            Console.WriteLine();
        }

        // Get the states with 4 characters
        public void FindAllFive()
        {
            var names = list.FindAll(s => s.Length <= 4);
            foreach (var s in names)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        // Exclude states that contain the string Al and get the number removed
        public void RemoveAl()
        {
            var removeCount = list.RemoveAll(s => s.Contains("Al"));
            Console.WriteLine(removeCount);
            Console.WriteLine();
        }

        // Output each element of the list
        public void ForeachConsole()
        {
            list.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
        }

        // Convert to lower case
        public void ConvertAllString()
        {
            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));
        }
    }
}