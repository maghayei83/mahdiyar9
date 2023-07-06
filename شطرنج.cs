using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] board = new char[8, 8];


            InitializeBoard(board);


            PrintBoard(board);
        }

        static void InitializeBoard(char[,] board)
        {

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    board[row, col] = ' ';
                }
            }


            for (int col = 0; col < 8; col++)
            {
                board[1, col] = '♟';
                board[6, col] = '♙';
            }


            board[0, 0] = '♜';
            board[0, 7] = '♜';
            board[0, 1] = '♞';
            board[0, 6] = '♞';
            board[0, 2] = '♝';
            board[0, 5] = '♝';
            board[0, 3] = '♛';
            board[0, 4] = '♚';

            board[7, 0] = '♖';
            board[7, 7] = '♖';
            board[7, 1] = '♘';
            board[7, 6] = '♘';
            board[7, 2] = '♗';
            board[7, 5] = '♗';
            board[7, 3] = '♕';
            board[7, 4] = '♔';
        }

        static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
class ChessBoard
{
    static void Main(string[] args)
   {
       
        char[,] board = new char[8, 8];

        
        InitializeBoard(board);

       
        PrintBoard(board);

        Console.ReadLine();
    }

    static void InitializeBoard(char[,] board)
    {
        
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 == 0)
                    board[row, col] = '■'; 
                else
                    board[row, col] = '□'; 
            }
        }
    }

    static void PrintBoard(char[,] board)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
