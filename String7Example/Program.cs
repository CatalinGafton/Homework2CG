using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class StringExample
    {


        public static void String7Example()
        {
            // Define .NET Strings 
            // String of characters  
            System.String authorName1 = "Ion Creanga";
            System.String authorName2 = "Vasile Alecsandri";
            System.String authorName3 = "Mihai Eminescu";
            System.String titleAuthor1 = "'Amintiri din copilarie'";

            // String made of an Integer  
            System.String age = "44";

            // String made of a double  
            System.String numberString = "33.23";

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
            Console.WriteLine("Numar: {0}", numberString);
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



        public static void Main(string[] args)
        {
           

            
        }
    }
}















