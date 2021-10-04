using System;

namespace PO_Week2
{
    class Program
    {
        static int BoardWidth;
        static int BoardHeight;

        static int[,] KnightMoves = new int[,]{
            { 1,  2},
            {-1,  2},
            { 1, -2},
            {-1, -2},
            { 2,  1},
            { 2, -1},
            {-2,  1},
            {-2, -1}
        };
        private static bool IsOnBoard(int x, int y)
        {
            if((x >= 0 && x < BoardWidth) && (y >= 0 && y < BoardHeight)) 
                return true;
            else
                return false;
        }

        private static bool IsSpaceValid(int x, int y, int[,] board)
        {
            for(int i = 0; i < 8; i++)
            {
                int testPosX = x + KnightMoves[i, 0],
                    testPosY = y + KnightMoves[i, 1];
                if(IsOnBoard(testPosX, testPosY) && board[testPosX, testPosY] == 1)
                    return false;
            }
            return true;
        }

        private static bool CannotCapture(int[,] board)
        {
            BoardWidth = board.GetLength(0);
            BoardHeight = board.GetLength(1);
            bool result = true;
            for(int x = 0; x < BoardWidth; x++)
                for(int y = 0 ; y < BoardHeight; y++)
                    if(board[x, y] == 1 && !IsSpaceValid(x, y, board)) return false;
            return result;
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(CannotCapture(
                new int[,] {
                    { 0, 0, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 1, 0, 1, 0 },
                    { 0, 1, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0, 0, 1 },
                    { 0, 0, 0, 0, 1, 0, 0, 0 }
                }));
    */
               
            Console.WriteLine(CannotCapture(
                new int[,] {
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {0, 0, 0, 1, 0, 1, 0, 1},
                    {1, 0, 0, 0, 1, 0, 1, 0},
                    {0, 0, 0, 0, 0, 1, 0, 1},
                    {1, 0, 1, 0, 1, 0, 1, 0},
                    {1, 0, 0, 1, 0, 0, 0, 1}
                })
            );
            
        }
    }
}
