using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RunTasks
    {

        public RunTasks()
        {

        }

        public void RunProgram()
        {

            string contin;
            string strNum;
            string str1 = "K K  KBJHAHBAHBJA! ccajcha KjabCJSB, LMDCDSCS! DNVADSDNAA K";

            int intNum;            
            int M = 1;
            int N = 10;
            int[] mas = new int[] { 1, -6, 5, -10, -8, 3 };
            int[,] mas1 = new int[,] { { 1, 6, 3, 4 }, { 5, 6, 12, 8 }, { 9, 10, 11, 12 } };

            bool run = true;

            AllTasks task = new AllTasks();

            while (run)
            {
                Console.Clear();
                Console.Write("Please write Number of task: ");
                strNum = Console.ReadLine();

                while (!int.TryParse(strNum, out intNum))
                {
                    Console.WriteLine("You write not value");
                    Console.Write("Try again: ");
                    strNum = Console.ReadLine();
                }

                switch (intNum)
                {

                    case 1:
                        Console.Clear();
                        task.Task1();
                        break;
                    case 2:
                        Console.Clear();
                        task.Task2();
                        break;
                    case 3:
                        Console.Clear();
                        task.Task3();
                        break;
                    case 4:
                        Console.Clear();
                        task.Task4();
                        break;
                    case 5:
                        Console.Clear();
                        task.Task5(10);
                        break;
                    case 6:
                        Console.Clear();
                        task.Task6(30);
                        break;
                    case 7:
                        Console.Clear();
                        task.Task7(mas);
                        break;
                    case 8:
                        Console.Clear();
                        task.Task8(mas);
                        break;
                    case 9:
                        Console.Clear();
                        task.Task9(mas);
                        break;
                    case 10:
                        Console.Clear();
                        task.Task10(mas, M, N);
                        break;
                    case 11:
                        Console.Clear();
                        task.Task11(mas1);
                        break;
                    case 12:
                        Console.Clear();
                        task.Task12(mas1);
                        break;
                    case 13:
                        Console.Clear();
                        task.Task13(mas1);
                        break;
                    case 14:
                        Console.Clear();
                        task.Task14(str1);
                        break;
                    case 15:
                        Console.Clear();
                        task.Task15(str1);
                        break;
                    case 16:
                        Console.Clear();
                        task.Task16(str1);
                        break;
                    case 17:
                        Console.Clear();
                        task.Task17(str1);
                        break;
                    case 18:
                        Console.Clear();
                        task.Task18(str1);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("So number is not exhist");
                        break;

                }

                Console.WriteLine("Do you want to continue? ( Write 1 if YES ): ");
                contin = Console.ReadLine();

                if(contin!="1")
                {
                    run = false;
                }
            }

        }
    }

    
}
