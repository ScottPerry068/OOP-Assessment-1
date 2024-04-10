using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Game
    {
        // creates the variables
        private int _DiceFace;// this variabl is created to hold the dice values
        private int _result; //this creates the result
        // creates the objects
        private Dice _Dice = new Dice(); // this creates the dice objects

        // runs the game
        public void Start() // this method is just used to run the dice game
        {
            int Temp = 0; // this is a temp value for my loop
            List<int> DiceRolledlist = new List<int>(); //this creates my rolled faces list

            for (int i = 0; i < 3; i++) // this creates the loop to roll 3 dice 
            {
                _DiceFace = _Dice.Roll(); //this rolls the dice
                DiceRolledlist.Add(_DiceFace); //this adds the rolled dice to the list
            }
            for (int i = 0; i < 3; i++) // this loop adds the three dice together
            {
                int Value = DiceRolledlist[i];
                _result = Value + Temp;
                Temp = _result;
            }
            Console.WriteLine("This is the result of 3 dice rolls:  " + _result);

        }
        
    }
}
