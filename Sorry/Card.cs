using System;

public class Card
{
    public enum VALUE
    {
       One = 1, TWO, THREE, FOUR, FIVE, SEVEN, EIGHT, TEN, ELEVEN, TWELVE, SORRY
    }
    public VALUE cardVal { get; set; }
   
    
    // public bool special { get; set; }
    // card types 1 2 3 4 5  7 8 10 11 12 Sorry!
    //There are 5 one cards and 4 of every other card totalling 45
    //Special cards are 4-backwards only
    //7- can be split between two pawns in play
    //10- forward 10 or back 1
    //11-forward 11 or swap any of the current players pawns in play with any other pawn in play
    //Sorry! swap a pawn in the start with any other players pawn in play.  
	
    //How do we tie the images to this class?
   

   
    
}
