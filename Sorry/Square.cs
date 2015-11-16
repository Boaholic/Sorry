using System;

namespace Sorry
{
    public class Square
    {
        private bool occupied;
        private Pawn occupiedBy;
        private int ownerPlayer;
        private color highlighted;
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