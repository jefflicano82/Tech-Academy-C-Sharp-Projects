using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Card() // Adding constructor.(This is the way to give default values. 
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //Gave the class properties.
        public string Face { get; set; } //The get method returns the value of the variable name .
                                         //The set method assigns a value to the name variable.
                                         //The value keyword represents the value we assign to the property.
    }
}
