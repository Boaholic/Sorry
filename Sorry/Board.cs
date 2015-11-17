using System;

namespace Sorry
{
    public class Board
    {   
        // Holds the square buttons
        public SquareType[][] board;
        // Holds the pawn data
        public Pawn[][] pawn;


        public Board()
        {
            for (int i = 0; i < 60; i++) {
                board[i][0] = SquareType.Normal;
                if (i % 15 == 2) {
                    //generate the homeRun Sequence
                    for (int j = 1; j < 6; j++)
                        board[i][j] = SquareType.HomeRun;
                    board[i][6] = SquareType.Home;
                }
                if (i % 15 == 4) {
                    board[i][1] = SquareType.Start;
                }
            }

        }
    }
}