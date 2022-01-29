using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLibs
    {
        static void Main(string[] args)
        {
            Console.Title = "MadLibs";
            Console.WriteLine("Please enter a plural noun: ");
            string ml1 = Console.ReadLine();
            Console.WriteLine("Please enter a plural noun: ");
            string ml2 = Console.ReadLine();
            Console.WriteLine("Please enter a verb: ");
            string ml3 = Console.ReadLine();
            Console.WriteLine("Please enter a noun: ");
            string ml4 = Console.ReadLine();
            Console.WriteLine("Please enter a -ing verb: ");
            string ml5 = Console.ReadLine();



            Console.WriteLine($"When I go to the arcade with my {ml1} there are lots of games to play. I spend lots of time there with my friends. In the game X-Men you can be different {ml2}. The point of the game is to {ml3} every robot. You also need to save people. Then you can go to the next level.\nIn the game Star Wars you are Luke Skywalker and you try to destroy every {ml4}. In a car racing/motorcycle racing game you need to beat every computarized vehicle that you are {ml5} against.");


        }//end main
    }//end class
}//end namespace
