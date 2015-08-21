using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            BubbleSortFunction a = new BubbleSortFunction();
            //bool flag = true;
            
            // input
            //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // process
            /*while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }*/

            // output
            /*for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }*/

            
             
            int [] inp = a.input();
            a.process(inp);
            a.output(inp);
            Console.ReadKey();
        }
        //function input
        public  int[] input()
        {
            string num;
            Console.WriteLine("Input number: ");
            num = Console.ReadLine();
            int[] input;
            input = num.Split(' ').Select(y => Convert.ToInt32(y)).ToArray(); ;
            return input;
 
        }

        public void process(int [] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }

        }

        public void output(int []input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }

    }
}
