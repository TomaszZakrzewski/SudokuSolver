using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Class2

    {
        public static void Solve(int[,] tabela)
        {
            int[,] solved = new int[9, 9];
            //int[,,] numbers = new int[9, 9, 9];

            for (int n = 0; n < 40; n++)
            {
                List<int>[,] lista = new List<int>[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        lista[i, j] = new List<int>();
                        if (tabela[i, j] == 0)
                        {

                            for (int k = 1; k <= 9; k++)
                            {
                                bool contains = false;
                                for (int l = 0; l < 9; l++)
                                {
                                    if (tabela[i, l] == k) { contains = true; }
                                    if (tabela[l, j] == k) { contains = true; }
                                }
                                if (!contains)
                                {
                                    if (BoxNotContains(tabela, i, j, k))
                                    {
                                        lista[i, j].Add(k);
                                    }
                                }
                            }
                            if (lista[i, j].Count() == 1)
                            {
                                tabela[i, j] = lista[i, j][0];
                            }
                           

                        }

                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                Console.Write("\n\n");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(tabela[i, j]);
                    Console.Write("\t");
                }
            }

            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write("\n\n");
            //    for (int j = 0; j < 9; j++)
            //    {
            //            foreach(int number in lista[i,j])
            //            { 
            //            Console.Write(number);
            //            }
            //        Console.Write("\t");
            //    }
            //}
        }
        static public bool BoxNotContains(int[,] tab, int row, int column, int value)
        {
            bool ok = true;
            if (column < 3)
            {
                if (row < 3)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 2 && row < 6)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        for (int p = 3; p < 6; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 5 && row < 9)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        for (int p = 6; p < 9; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
            }
            if (column > 2 && column < 6)
            {
                if (row < 3)
                {
                    for (int l = 3; l < 6; l++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 2 && row < 6)
                {
                    for (int l = 3; l < 6; l++)
                    {
                        for (int p = 3; p < 6; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 5 && row < 9)
                {
                    for (int l = 3; l < 6; l++)
                    {
                        for (int p = 6; p < 9; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
            }
            if (column > 5 && column < 9)
            {
                if (row < 3)
                {
                    for (int l = 6; l < 9; l++)
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 2 && row < 6)
                {
                    for (int l = 6; l < 9; l++)
                    {
                        for (int p = 3; p < 6; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }
                if (row > 5 && row < 9)
                {
                    for (int l = 6; l < 9; l++)
                    {
                        for (int p = 6; p < 9; p++)
                        {
                            if (tab[l, p] == value)
                                ok = false;
                        }
                    }
                }

            }
            return ok;
        }




    }
}

