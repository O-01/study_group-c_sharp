using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World");
            Console.Write("Beginning - ");
            Console.Write("Middle - ");
            Console.Write("End\n");
            // Comment
            /* This comment has multiple lines. Its lines are multiple which
            means that there are more than one of them, possibly even many. A
            line is usually found to end with the line break '\n' */
            string test_string = "I'm alright.";
            Console.WriteLine(test_string);
            int test_int = 12;
            Console.WriteLine(test_int);
            test_int = 48;
            Console.WriteLine(test_int);
            char new_line = '\n';
            string str_1 = "\"" + test_int.ToString() + "\"" + new_line.ToString();
            Console.Write(str_1);
        }
    }
}
