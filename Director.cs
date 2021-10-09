using System;

namespace cse210_tc04
{
    /// <summary>
    /// Like a director in a play, this class is responsible for the game, the script,
    /// the actors, and all of their interactions.
    /// 
    /// For this program, it has responsibility for the score, coordinating with the
    /// player to choose, and the sequence of play.
    /// </summary>
    class Director
    {
        bool _keepPlaying = true;
        int _score = 0;
        Dealer _dealer = new Dealer();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                UserInput();

                if (_keepPlaying)
                {
                    UpdateScore();
                    DisplayOutput();
                }
            }
        }
        ///<summary>
        ///</summary>
        void UserInput()
        {
           if (!_dealer.IsFirstTurn())
            {
                Console.WriteLine("Keep playing? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
            }
        }
        ///<summary>
        ///</summary>
        void UpdateScore()
        {
            _dealer.ResetDeal();

            _dealer.CheckGuess();

            _dealer.CheckScore(_score);
        }
        ///<summary>
        ///</summary>
        void DisplayOutput()
        {
            string cardString = _dealer.DisplayCards();

            Console.WriteLine();
            Console.WriteLine($"Next card was: {cardString}");
            Console.WriteLine($"Your score is: {_score}");
        }

        /*
        void GetInputs()
        {
            if (!_thrower.IsFirstThrow())
            {
                Console.WriteLine("Roll again? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
            }
        }

        void DoUpdates()
        {
            _thrower.ThrowDice();

            if (_thrower.ContainsScoringDie())
            {
                _score += _thrower.GetPoints();
            }
            else
            {
                _score = 0;
            }
        }

        void DoOutputs()
        {
            string diceString = _thrower.GetDiceString();

            Console.WriteLine();
            Console.WriteLine($"You rolled: {diceString}");
            Console.WriteLine($"Your score is: {_score}");

            if (!_thrower.CanThrow())
            {
                Console.WriteLine("Game Over");
                _keepPlaying = false;
            }
        } */

    } // end of class: Director
}
