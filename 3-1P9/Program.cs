using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1P9
{
    class Program
    {
        interface Летающий
        {
            string Взлететь();
        }

        interface Птица : Летающий
        {
            string Кушать();
        }

        interface Самолет: Летающий
        {
            string Заправиться();
        }

        class Утка : Птица
        {
            public string Взлететь()
            {
                return "Кря-Кря";
            }

            public string Кушать()
            {
                return "Ням-Ням";
            }
        }

        class Боинг : Самолет
        {
            public string Взлететь()
            {
                return "ЖЖЖЖ";
            }

            public string Заправиться()
            {
                return "Буль-Буль";
            }
        }


        static void Main(string[] args)
        {
            Летающий[] летающие = new Летающий[2];
            летающие[0] = new Утка();
            летающие[1] = new Боинг();
            for (int i = 0; i < летающие.Length; i++)
            {
                Console.WriteLine(летающие[i].Взлететь());
                if(летающие[i] is Самолет)
                    Console.WriteLine((летающие[i] as Самолет).Заправиться()); 
            }


            int[] m1 = new int[10];
            int[] m1_1 = new int[] { 2, 3, 4, 5, 7, 8 };
            int[,] m2 = new int[5, 5];
            int[,,] m4 = new int[3, 3, 3];
            m4[0, 0, 0] = 1;
            int[,] m2_1 = new int[,] {
                { 1, 2, 4, 5 },
                { 1, 2, 4, 5 },
                { 1, 2, 4, 5 },
                { 1, 2, 4, 5 }};
            int[][] m3 = new int[5][];
            for (int i = 0; i < m3.Length; i++)
            {
                m3[i] = new int[i+1];
                for (int j = 0; j < m3[i].Length; j++)
                {
                    m3[i][j] = j+1;
                }
            }

            //m3[0] = new int[] { 1 };
            //m3[1] = new int[] { 1, 2 };
            //m3[2] = new int[] { 1, 2,3 };
            //m3[3] = new int[] { 1,2,3,4 };
            //m3[4] = new int[] { 1,2,3,4,5 };

            for (int i = 0; i < m1_1.Length; i++)
            {
                Console.WriteLine(m1_1[i]);
            }

            int[][] m5 = new int[m2.GetLength(0)][];
            for (int i = 0; i < m5.Length; i++)
            {
                m5[i] = new int[m2.GetLength(1)];
                for (int j = 0; j < m5[i].Length; j++)
                {
                    m5[i][j] = m2[i, j];
                }
            }

            for (int i = 0; i < m2_1.GetLength(0); i++)
            {
                for (int j = 0; j < m2_1.GetLength(1); j++)
                {
                    Console.Write(m2_1[i,j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m3.Length; i++)
            {
                for (int j = 0; j < m3[i].Length; j++)
                {
                    Console.Write(m3[i][j]);
                }
                Console.WriteLine();
            }

            #region del
            try
            {
                Ops();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
            try
            {
                int[] m = new int[0];
                m[0] = 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Я ожидал это");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("done");
            }
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Еще раз");
            }

            Console.ReadLine();
        }

        public static void Ops()
        {
            throw new MyException("Нет корней");
        }

        public class MyException : Exception
        {
            public MyException(string message)
                : base(message)
            {

            }
        }
    }
}
