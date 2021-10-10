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
        int _current_card_number = 0;
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
            _dealer.DisplayCards();

           if (!_dealer.IsFirstTurn())
            {
                Console.WriteLine("Keep playing? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
            } 
            Console.WriteLine("Higher or lower? ");
            _dealer._guess = Console.ReadLine();
            _dealer.CheckGuess(_dealer._guess);
        }
        ///<summary>
        ///</summary>
        void UpdateScore()
        {
            _dealer.ResetDeal();

            _dealer.CheckGuess(_dealer._guess);

            _dealer.CheckScore(_dealer._score);
        }
        ///<summary>
        ///</summary>
        void DisplayOutput()
        {
            _dealer.DisplayCards();

            Console.WriteLine();
            Console.WriteLine($"Next card was: {_dealer._current_card_number}");
            Console.WriteLine($"Your score is: {_dealer._score}");
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
