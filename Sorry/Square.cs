using System;
using System.Drawing;

namespace Sorry
{
    public class Square
    {
        public Square(SquareType startType)
        {
            type = startType;

        }
        public SquareType type;
        // Returns true if there is a pawn already in the square
        private bool occupied;
        // Stores which pawn is in the square
        private Pawn occupiedBy;
        // Shows if the square belongs to a player i.e "Home Spaces"
        private int ownerPlayer;
        // Lights up the square if it is a valid move
        private Color highlighted;
        public Square()
        {

        }
        //This may need to be changed. If we want it to return a bool 
        //of occupied instead of returning the pawn it is occupied by
        //There may need to be a way to say it is not occupied in the
        //Pawn class
        public Pawn IsOccupied()
        { 
            return occupiedBy; 
        }
        public Pawn SetOccupied(Pawn newPawn)
        {
            occupiedBy = newPawn;
            return occupiedBy; 
        }
    }
};