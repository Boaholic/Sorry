﻿using System;

public class Card
{
    public int cardNumber { get; set; }
    public bool special { get; set; }
	public Card(int newNumber, bool newSpecial)
	{
        cardNumber = newNumber;
        special = newSpecial;
	}
    //How do we tie the images to this class?
}
