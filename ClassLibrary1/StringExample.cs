using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    public class StringExample
    {


        public static void StringExample1()
        {
          
            // String of characters  
            System.String authorName1 = "Ion Creanga";
            System.String authorName2 = "Vasile Alecsandri";
            System.String authorName3 = "Mihai Eminescu";
            System.String titleAuthor1 = "'Amintiri din copilarie'";

            // String made of an Integer  
            System.String age = "44";

            // String made of a double  
            System.String number = "44.00";

            // String using ToString Method
            string authorInfo = string.Format("{0} a scris {1} la varsta de {2} de ani.", authorName1, titleAuthor1.ToString(), age.ToString());

            // String with whitespaces  
            string hello = "Salut, aceasta fraza a avut spatii libere la sfarsit              ";


            // Write to Console.  

            //  1
            Console.WriteLine("Autor: {0}", authorName1);
            //  2
            Console.WriteLine("Varsta: {0}", age);
            //  3
            Console.WriteLine("Numar: {0}", number);
            //  4
            Console.WriteLine(authorInfo);
            //  5
            Console.WriteLine("Dimensiunea Stringului {0} caractere (inclusiv spatiile) ", authorInfo.Length);
            //  6
            // Compare strings using String.Equals  
            if (String.Equals(authorName2, authorName3))
                Console.WriteLine($"{authorName2} si {authorName3} au aceeasi valoare.");
            else
                Console.WriteLine($"{authorName2} si {authorName3} sunt diferiti.");
            //  7
            // Remove whitespaces from both ends  
            Console.WriteLine(hello.TrimEnd() + ".");
            Console.ReadKey();
        }
        

        public static void StringExamplE2()
        {
            // 1
            string ex1 = string.Concat("abc", 3, "ef", "g.      ");
            // 2
            string ex2 = "abc3efg     .";
            // 3  
            int ex3 = string.Compare(ex1, ex2);
            // 4
            bool ex4 = string.Equals(ex1, ex2);
            // 5
            bool ex5 = string.IsNullOrEmpty(ex1);
            // 6
            string ex6 = string.Join("/", ex1, ex2);
            // 7
            int ex7 = string.CompareOrdinal(ex1, ex2);
            // 8
            string ex8 = ex1.TrimEnd();

            Console.WriteLine("Example 1 String Concat:             " + ex1);
            Console.WriteLine("Example 2 String Characters:         " + ex2);
            Console.WriteLine("Example 3 String Compare:            " + ex3);
            Console.WriteLine("Example 4 String Equals:             " + ex4);
            Console.WriteLine("Example 5 String Is Null Or Empty:   " + ex5);
            Console.WriteLine("Example 6 String Join:               " + ex6);
            Console.WriteLine("Example 7 String Compare Ordinal:    " + ex7);
            Console.WriteLine("Example 8 String Trim End:           " + ex8);
            Console.ReadKey();
        }
    }
}















