using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Class2
    {
                static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        chessBoard[row, col] = '#';
                    }
                    else
                    {
                        chessBoard[row, col] = ' ';
                    }
                }
            }

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(chessBoard[row, col]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
    }
}
