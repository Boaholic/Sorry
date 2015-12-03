using System;

namespace Sorry
{
    public class Board
    {   
        // Holds the square buttons
        public SquareType[][] board;
        // Holds the pawn data
        public Pawn[][] pawn;
        //testing comment

        public Board()
        {
            board = new SquareType[60][];
            for (int i = 0; i < 60; i++) {
                board[i] = new SquareType[1];
                board[i][0] = SquareType.Normal;
                if (i % 15 == 2) {
                    //generate the homeRun Sequence
                    board[i] = new SquareType[10];
                    board[i][0] = SquareType.Normal;
                    for (int j = 1; j < 9; j++)
                    {
                        board[i][j] = SquareType.HomeRun;
                        if (j > 5)
                        {
                            board[i][j] = SquareType.Home;
                        }
                            
                    }
                }
                if (i % 15 == 4) {
                    board[i] = new SquareType[5];
                    board[i][0] = SquareType.Normal;
                    for (int j = 1; j < 5; j++)
                        board[i][j] = SquareType.Start;
                }
            }

        }
    }
}