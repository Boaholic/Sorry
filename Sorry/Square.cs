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