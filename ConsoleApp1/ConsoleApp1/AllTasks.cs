using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

   public class AllTasks
    {

        public AllTasks()
        {

        }

        // С клавиатуры вводятся 3 числа. Вывести их в порядке возрастания (Например: 4, 7, 2 → 2, 4, 7).

        public void Task1()
        {

            string a;
            string b;
            string c;
            int[] nums = new int[3];
            int numsLength = nums.Length;
            bool isSort = false;            

            Console.WriteLine("Please write 3 numbers:");
            Console.Write("First: ");
            a = Console.ReadLine();
            Console.Write("Second: ");
            b = Console.ReadLine();
            Console.Write("Third: ");
            c = Console.ReadLine();

            while(!int.TryParse(a,out nums[0]))
            {
                Console.WriteLine("First argument is not value");
                Console.WriteLine("Try again: ");
                Console.Write("First: ");
                a = Console.ReadLine();                    
            }

            while(!int.TryParse(b, out nums[1]))
            {
                Console.WriteLine("Second argument is not value");
                Console.WriteLine("Try again: ");
                Console.Write("Second: ");
                b = Console.ReadLine();
            }

            while(!int.TryParse(c, out nums[2]))
            {
                Console.WriteLine("Third argument is not value");
                Console.WriteLine("Try again: ");
                Console.Write("Third: ");
                c = Console.ReadLine();
            }

            Console.WriteLine("\nResult: ");
            Console.Write(nums[0] + "," + nums[1] + "," + nums[2] + " -> ");
           
            while (!isSort)
            {
                int counter = 0;

                for (int i = 0; i < numsLength-1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int val = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = val;
                        counter++;
                    }
                }

                if(counter==0)
                {
                    isSort = true;
                }
            }

            Console.WriteLine(nums[0] + "," + nums[1] + "," + nums[2]);
            Console.ReadLine();

        }

       // С клавиатуры вводится число, вывести его в обратном порядке(358 → 853).

        public void Task2()
        {

            string str;
            int number;
            int length;
            Console.Write("Write a Number: ");
            str = Console.ReadLine();

            while (!int.TryParse(str, out number))
            {
                Console.Clear();
                Console.WriteLine("You write not a number");
                Console.Write( $"Try again: ");                
                str = Console.ReadLine();
            }

            Console.Write($"Result: {str} -> ");
            length = str.Length;

            for(int i = 0; i < length; i++)
            {
                Console.Write(str[length-i-1]);
            }

            Console.WriteLine( );
            Console.ReadLine();

        }

        // Реализовать метод вычисляющий факториал из числа введенного
        // с клавиатуры (5 → 120).

        public void Task3()
        {

            string str;
            int number;
            int factorial=1;
            bool stop = false;
                      
            Console.Write("Write a Number: ");
            str = Console.ReadLine();

            while (!int.TryParse(str, out number))
                {
                    Console.Clear();
                    Console.WriteLine("You write not a number");
                    Console.Write($"Try again: ");
                    str = Console.ReadLine();
                }
          
            while (!stop)
            {
                if (number >= 0)
                {
                    stop = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please write a positive number ");
                    Console.Write("Write a Number: ");
                    str = Console.ReadLine();

                    while (!int.TryParse(str, out number))
                    {
                        Console.Clear();
                        Console.WriteLine("You write not a number");
                        Console.Write($"Try again: ");
                        str = Console.ReadLine();
                    }
                }
            }
            
            Console.Write($"Result: {str} -> ");   
            
            for (int i=2;i<=number;i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
            Console.ReadLine();

        }

        // Получить сумму первых N чисел с шагом M от числа X 
        // (X=10 N=5 M=2 → 10+12+14+16+18=70).

        public void Task4()
        {

            int N = 5;
            int M = 2;
            int X = 10;            
            int sum = X; 

            Console.Write($"X={X} N={N} M={M} -> {X}");

            for(int i = 1; i < N; i++)
            {
                Console.Write($"+{X + i * M}");
                sum = sum + X + i * M;                
            }

            Console.WriteLine($"={sum}");            
            Console.ReadLine();

        }

        // Реализовать метод, который получает число X и возвращает 
        // все четные числа в диапазоне от 0..X (X=10 → 0, 2, 4, 6, 8, 10).

        public void Task5(int x)
        {

            Console.WriteLine("Result: ");
            Console.Write($"X={x} -> 0");

            for (int i=1;i<=x;i++)
            {
                if(i%2==0)
                {
                    Console.Write($", {i}");
                }
            }

            Console.WriteLine();
            Console.ReadLine();

        }

        // Реализовать метод который получает число X и возвращает все 
        // cовершенные числа в диапазоне 0..X (X=10 → 6).

        public void Task6(int x)
        {

            int sum = 0;
            Console.WriteLine("Result: ");
            Console.Write($"X={x} -> ");

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j; 
                    }
                }
                if(i==sum)
                {
                    Console.Write($"{i} ");
                }
                sum = 0;
            }

            Console.WriteLine();
            Console.ReadLine();

        }

        // Дан одномерный массив получить сумму всех элементов расположенных в
        // четных и отдельно в нечетных позициях.

        public void Task7(int[] x)
        {

            int sumChet = 0;
            int sumNechet = 0;

            for(int i=0;i<x.Length;)
            {
                sumNechet = sumNechet + x[i];
                i = i + 2;
            }

            for (int i = 1; i < x.Length;)
            {
                sumChet = sumChet + x[i];
                i = i + 2;
            }

            Console.WriteLine("Result:");
            Console.WriteLine($"Sum chet positions: {sumChet}");
            Console.WriteLine($"Sum Nechet positions: {sumNechet}");
            Console.WriteLine();
            Console.ReadLine();

        }

        //Дан одномерный массив отсортировать отрицательные элементы. 
        // ([4, -1, 1, -2] → [4, -2, 1, -1])

        public void Task8(int[] x)
        {

            int negativeLength = 0;
            int[] negativeMas;
            int[] negativePos;
            int j = 0;            
            bool isSort = false;

            Console.WriteLine("Result: ");
            Console.Write($"[{x[0]}, ");

            for(int i=1;i<x.Length-1;i++)
            {
                Console.Write($"{x[i]}, ");
            }

            Console.Write($"{x[x.Length-1]}] ->  ");

            for (int i = 0; i < x.Length;i++)
            {
                if(x[i]<0)
                {
                    negativeLength++;
                }
            }

            negativeMas = new int[negativeLength];
            negativePos = new int[negativeLength];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    negativeMas[j] = x[i];
                    negativePos[j] = i;
                    j++;
                }
            }

            while (!isSort)
            {
                int counter = 0;

                for (int i = 0; i < negativeLength - 1 ; i++)
                {
                    if (negativeMas[i] > negativeMas[i + 1])
                    {
                        int val = negativeMas[i];
                        negativeMas[i] = negativeMas[i + 1];
                        negativeMas[i + 1] = val;
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    isSort = true;
                }
            }

            for (int i = 0; i < negativeLength ; i++)
            {
                x[negativePos[i]] = negativeMas[i];
            }

            Console.Write($"[{x[0]}, ");

            for (int i = 1; i < x.Length - 1; i++)
            {
                Console.Write($"{x[i]}, ");
            }

            Console.Write($"{x[x.Length - 1]}] ");
            Console.WriteLine();
            Console.ReadLine();

        }

        // Дан массив преобразовать его, так чтобы последний поменялась с первой 
        // предпоследний с вторым и т.д.

        public void Task9(int[] x)
        {

            int temp;

            Console.WriteLine("Result: ");
            Console.Write($"[{x[0]}, ");

            for (int i = 1; i < x.Length - 1; i++)
            {
                Console.Write($"{x[i]}, ");
            }

            Console.Write($"{x[x.Length - 1]}] ->  ");

            for (int i = 0; i < x.Length/2 ; i++)
            {
                temp = x[i];
                x[i] = x[x.Length - 1 - i];
                x[x.Length - 1 - i] = temp;
            }

            Console.Write($"[{x[0]}, ");

            for (int i = 1; i < x.Length - 1; i++)
            {
                Console.Write($"{x[i]}, ");
            }

            Console.Write($"{x[x.Length - 1]}] ");
            Console.WriteLine();
            Console.ReadLine();

        }

        // Дан одномерный массив, получить сумму элементов которые: 
        // a) больше числа M b) Меньше числа N

        public void Task10(int[] x, int M, int N)
        {

            int sumM = 0;
            int sumN = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if(x[i] > M)
                {
                    sumM = sumM + x[i];
                }

                if (x[i] < M)
                {
                    sumN = sumN + x[i];
                }                
            }

            Console.WriteLine("Result: ");
            Console.WriteLine($"Sum more then M({M}) = {sumM}");
            Console.WriteLine($"Sum smaller then N({N}) = {sumN}");

            Console.ReadLine();

        }

        // Дан двумерный массив, поменять местами четные строки с нечетными.

        public void Task11(int[,] mas)
        {

            int temp;            
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.GetUpperBound(1) + 1;

            Console.WriteLine("Start massive: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i,j]+" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows - rows % 2;)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[i + 1, j];
                    mas[i + 1, j] = temp;
                }

                i = i + 2;
            }

            Console.WriteLine();
            Console.WriteLine("End massive: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        // Дан двумерный массив получить максимальные элемента каждого столбца.

        public void Task12(int[,] mas)
        {

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.GetUpperBound(1) + 1;
            int[] max = new int [rows];

            for (int j = 0; j < rows; j++)
            {
                max[j] = mas[j, 1];
            }

            Console.WriteLine("Start massive: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    if(mas[i, j] > max[i])
                    {
                        max[i] = mas[i, j];
                    }
                }                
            }

            Console.WriteLine();
            Console.WriteLine("Max elements in columns is: ");

            for (int j = 0; j < rows; j++)
            {
                Console.WriteLine($"{j+1}: {max[j]}"); 
            }

            Console.ReadLine();

        }

        // Дан двумерный массив поменять местами элементы, 
        // расположенные на главной диагонали с противоположной диагонально.

        public void Task13(int[,] mas)
        {

            int temp;
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.GetUpperBound(1) + 1;

            Console.WriteLine("Start massive: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                temp = mas[i,i];
                mas[i, i] = mas[i, columns - 1 - i];
                mas[i, columns - 1 - i] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("End massive: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        // Дана строка, посчитать количество символов "A"

        public void Task14(string str)
        {     
            
             Console.WriteLine($"Your string is: {str}");
             string str1 = str.Replace("A","");             
             int counter = str.Length - str1.Length;
             Console.WriteLine($"A number of characters \"A\" is: {counter}");
             Console.ReadLine();

        }

        // Дана строка, посчитать количество слов.

        public void Task15(string str)
        {

            int counter = 0;
            Console.WriteLine($"Your string is: {str}");

            if(str[0]!=' ')
            {
                counter = counter + 1;
            }

            for(int i = 0; i < str.Length - 1; i++)
            {
                if(str[i]==' '&&str[i+1]!=' ')
                {
                    counter = counter + 1;
                }
            }

            Console.WriteLine($"A number of words is: {counter}");
            Console.ReadLine();

        }

        // Дана строка, перевернуть ее (компьютер → ретюьпмок).

        public void Task16(string str)
        {

            char[] newStr = new char[str.Length];
            string newString;
            int lenght = str.Length;

            Console.WriteLine($"Your string is: {str}");

            for(int i = 0; i < lenght;i++)
            {                
                newStr[i] = str[lenght - 1 - i];
            }

            newString = new string(newStr);

            Console.WriteLine($"New string is: {newString}");
            Console.ReadLine();

        }

        // Дана строка, поменять все символы "C" на "E".

        public void Task17(string str)
        {

            Console.WriteLine($"Your string is: {str}");           
            string str1 = str.Replace("C", "E");            
            Console.WriteLine($" New string is: {str1}");
            Console.ReadLine();

        }

        // Дана строка, посчитать количество слов, которые начинаются на букву "K".

        public void Task18(string str)
        {

            int counter = 0;

            Console.WriteLine($"Your string is: {str}");

            if (str[0]=='K')
            {
                counter = counter + 1;
            }

            string str1 = str.Replace(" K", "");
            counter = counter + (str.Length - str1.Length) / 2;

            Console.WriteLine($"Result is: {counter}");
            Console.ReadLine();

        }

    }

}
