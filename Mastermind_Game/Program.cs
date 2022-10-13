using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Game
{
    class Program
    {
        public static int[] SystemCodeMaker;
        public static int[,] codebracker;
        public static int size;
        public static int no;
        static void Main(string[] args)
        {
            //initialize an array
            SystemCodeMaker = new int[4];
            codebracker = new int[10, 4];
            size = codebracker.Length;
            int temp = 1;

            TwoDPrintarray(codebracker);

            while (size > 0)
            {

                Console.WriteLine("Enter the 4 numbers such as( 1234)");
                no = int.Parse(Console.ReadLine());

                TwoDPrintarray(AllocateElements(codebracker, GetDigits(no), temp));
                size = size - 4;
                temp++;

            }
        }
          public static int[,] AllocateElements(int[,] arr, int[] digits,int temp)
        {
           for (int i = arr.GetLength(0) - temp; i >= 0; i--)
                {
                    for (int j =0; j <arr.GetLength(1); j++)
                    {
                        arr[i, j] = digits[j];
                    }
                    break;
                }

           
            return arr;
        }

        public static int[] GetDigits(int n)
        { 
            int[] digits=new int[SystemCodeMaker.Length];
            int i = SystemCodeMaker.Length-1;
            while (n != 0)
            {
               
                int reminder = n % 10;
                digits[i] = reminder;
                i--;
                n = n / 10;
            }
            return digits;
        }

         public static void TwoDPrintarray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }


        
    }
}
