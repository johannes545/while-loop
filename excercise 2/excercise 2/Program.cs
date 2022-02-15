using System;

namespace excercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteSubject = "";
            
            
            Console.WriteLine("what is your favorite school subject?");
            
            favoriteSubject = Console.ReadLine();
            switch (favoriteSubject.ToLower())
            {
                case "Math":
                    Console.WriteLine("wow your a real chad");
                    break;
                case "Science":
                    Console.WriteLine("gosh dang it, stem field money inc");
                    break;
                case "English":
                    Console.WriteLine("useless subject ://");
                    break;
                case "Danish":
                    Console.WriteLine("what are you, a dane? kek");
                    break;
                case "social studies":
                    Console.WriteLine("time to take communications, and use it to start a blog etuu");
                    break;
                default:
                    Console.WriteLine("pick between Danish,Math,Science,English and Social studies");
                    break;
            }
        }
    }
}
