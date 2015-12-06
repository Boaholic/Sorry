using System;
using System.Collections.Generic;

namespace Sorry
{
    public class Board
    {
        // Holds the square buttons
        public List<List<Square>> board;
        // Holds the pawn data
        public List<List<Pawn>> pawns;
        //testing comment

        public Board()
        {
            board = new List<List<Square>>();
            pawns = new List<List<Pawn>>();
            for (int i = 0; i < 60; i++)
            {
                board.Add(new List<Square>());
                board[i].Add(new Square(SquareType.Normal));
                if (i % 15 == 2)
                {
                    //generate the homeRun Sequence
                    for (int j = 1; j < 6; j++)
                    {
                        board[i].Add(new Square(SquareType.HomeRun));
                    }
                    board[i].Add(new Square(SquareType.Home));
                }
                if (i % 15 == 4)
                {
                    board[i].Add(new Square(SquareType.Start));
                    pawns.Add(new List<Pawn>());
                    int temp = i / 15;
                    pawns[temp].Add(new Pawn(i, 1, temp));
                    board[i][1].SetOccupied(pawns[temp][0]);
                }
            }

        }
        public bool validateDistance(Square start, Square end, int distance)
        {
            int x = 0, y = 0;
            int startx = 0, starty = 0;
            int endx = 0, endy = 0;
            foreach (var list in board)
            {
                foreach (var item in list)
                {
                    if (item == start)
                    {
                        startx = x;
                        starty = y;
                    }
                    if (item == end)
                    {
                        endx = x;
                        endy = y;
                    }
                    y++;
                }
                y = 0;
                x++;
            }

            //needs work, on the logic here
            if (endx - startx + endy - starty == distance)
            {
                return true;
            }
            return false;


        }


    }
}