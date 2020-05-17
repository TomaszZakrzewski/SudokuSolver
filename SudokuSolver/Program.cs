using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int l = 0;
            int[,] tablica = new int[9, 9];
            Console.CursorVisible = false;
            while(true)
            {
                Console.WriteLine("********** Aplikacja konsolowa do rozwiazywania Sudoku **********");
                Console.WriteLine("**********   Uzupelnij minimum 30 pol aby rozpoczac!   **********");
                for (int i = 0;i<9;i++)
                {
                    Console.WriteLine("\n\n");
                    for (int j = 0; j < 9; j++)
                    {
                        if(k==i&&l==j)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            
                        }
                        Console.Write(tablica[i,j]);
                        Console.Write("\t");
                        Console.ResetColor();
                    }
                    
                }
                Console.WriteLine();
                
                ConsoleKeyInfo okey = Console.ReadKey();
                
                if(Char.IsDigit(okey.KeyChar))
                {
                    tablica[k, l] = okey.KeyChar -48;
                }
                if (okey.Key == ConsoleKey.DownArrow)
                {
                    if (k == 9) { k = 0; }
                    else { k++; }
                }
                else if (okey.Key == ConsoleKey.UpArrow)
                {
                    if (k < 0) { k = 8; }
                    else { k--; }
                }
                else if (okey.Key == ConsoleKey.RightArrow)
                {
                    if (l == 9) { l = 0; }
                    else { l++; }
                }
                else if (okey.Key == ConsoleKey.LeftArrow)
                {
                    if (l == -1) { l = 8; }
                    else { l--; }
                }
                else if (okey.KeyChar == 's')
                {
                    Solve(tablica);
                    Console.ReadKey();
                }




                Console.Clear();
                
               
            }

            
            
            

                

        }
        public static void Solve(int[,] tabela)
        {
            int[,] solved = new int[9, 9];
            //int[,,] numbers = new int[9, 9, 9];
            
            for(int n=0;n<40;n++)
            { 
            List<int>[,] lista = new List<int>[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    lista[i, j] = new List<int>();
                    int valid = 0;
                    int count = 0;
                    if (tabela[i,j] == 0)
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
                                    bool ok = true;
                                     if (i < 3)
                                    {
                                        if (j < 3)
                                        {
                                            for (int l = 0; l < 3; l++)
                                            {
                                                for (int p = 0; p < 3; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 2 && j < 6)
                                        {
                                            for (int l = 0; l < 3; l++)
                                            {
                                                for (int p = 3; p < 6; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 5 && j < 9)
                                        {
                                            for (int l = 0; l < 3; l++)
                                            {
                                                for (int p = 6; p < 9; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                    }
                                    if (i > 2 && i < 6)
                                    {
                                        if (j < 3)
                                        {
                                            for (int l = 3; l < 6; l++)
                                            {
                                                for (int p = 0; p < 3; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 2 && j < 6)
                                        {
                                            for (int l = 3; l < 6; l++)
                                            {
                                                for (int p = 3; p < 6; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 5 && j < 9)
                                        {
                                            for (int l = 3; l < 6; l++)
                                            {
                                                for (int p = 6; p < 9; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                    }
                                    if (i > 5 && i < 9)
                                    {
                                        if (j < 3)
                                        {
                                            for (int l = 6; l < 9; l++)
                                            {
                                                for (int p = 0; p < 3; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 2 && j < 6)
                                        {
                                            for (int l = 6; l < 9; l++)
                                            {
                                                for (int p = 3; p < 6; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                        if (j > 5 && j < 9)
                                        {
                                            for (int l = 6; l < 9; l++)
                                            {
                                                for (int p = 6; p < 9; p++)
                                                {
                                                    if (tabela[l, p] == k)
                                                        ok = false;
                                                }
                                            }
                                        }
                                    }
                                    if (ok)
                                    {
                                        lista[i,j].Add(k);
                                    }
                            }
                        }
                        for (int l = 0; l < 9; l++)
                        {
                            if(lista[i, j].Count()==1)
                            {
                                    tabela[i, j] = lista[i, j][0]; ;
                            }
                                else 
                                {
                                List<int> Row = new List<int>();
                                List<int> Column = new List<int>();

                                for (int m = 0; m < 9; m++)
                                {
                                    if (lista[i, l] != null)
                                        Row.AddRange(lista[i, l]);
                                    if (lista[l, j] != null)
                                        Column.AddRange(lista[l, j]);
                                }
                                var OccursOnceinRow = from g in Row.GroupBy(x => x)
                                                 where g.Count() == 1
                                                 select g.First();
                                int number = OccursOnceinRow.FirstOrDefault();
                                if (number != 0)
                                {
                                    for (int m = 0; m < 9; m++)
                                    {
                                        if (lista[i, m] != null)
                                            if (lista[i, m].Contains(number))
                                                tabela[i, m] = number;
                                    }
                                }
                                var OccursOnceinCol = from g in Row.GroupBy(x => x)
                                                    where g.Count() == 1
                                                    select g.First();
                                int number1 = OccursOnceinCol.FirstOrDefault();
                                if (number != 0)
                                {
                                    for (int m = 0; m < 9; m++)
                                    {
                                        if (lista[m, j] != null)
                                            if (lista[m, j].Contains(number1))
                                                tabela[m, j] = number1;
                                    }
                                }
                                }
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
        

    }
}
