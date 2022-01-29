using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {
            Console.Title = "Fruit Loops";
            string[] fruitLoops = new string[6];

            fruitLoops[0] = "Orange";
            fruitLoops[1] = "Apple";
            fruitLoops[2] = "Banana";
            fruitLoops[3] = "Mango";
            fruitLoops[4] = "Grape";
            fruitLoops[5] = "Pineapple";

            string periods = "";

            
            

            for (int i = 0; i < fruitLoops.Length; i++)
            {
                
                Console.WriteLine(fruitLoops[i] + "\n" + periods);
                periods += ".";

            }

            



        }//end main
    }//end class
}//end namespace
