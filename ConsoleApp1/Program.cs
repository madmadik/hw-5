using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Написать программу, которая обращается к элементам массива по индексу
 * и выходит за его пределы.
 * После обработки исключения вывести в финальном 
 * блоке сообщение о завершении обработки массива.*/
namespace ConsoleApp1
{
    class Program
    {
        static double number;

        static void Division(int number1,int number2)
        {

            if(number1==0&&number2==0)
            {
                throw new ArgumentNullException();
            }

            if(number1!=0&&number2==0)
            {
                throw new ArgumentException();
            }

            number = number1 / number2;

        }
        static void Main(string[] args)
        {

            try
            {
                int number1 = 7, number2 = 0;
                Division(number1, number2);
            }

            catch(ArgumentNullException exception)
            {
                Console.Out.WriteLine(exception.Message);
            }

            catch(ArgumentException exception)
            {
                Console.Out.WriteLine(exception.Message);
            }

            int [] matrix=new int[5];

            try
            {
                for (int i = 0; i < 7; i++)
                {
                    matrix[i] = 7;
                }
            }

            catch(IndexOutOfRangeException exception)
            {
                Console.Out.WriteLine("обработка массива окончена ,"+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
