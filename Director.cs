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
        int _score;
        int _current_card_number = 0;
        int rounds;
        Dealer _dealer = new Dealer();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                CurrentNumber();
                GuessNumber();
                DisplayScore();
                UserInput();
                
            }
        }
        ///<summary>
        ///</summary>

        void CurrentNumber ()
        {
            string CurrentNumber = _dealer.DisplayCard();
            Console.WriteLine($"The card is: {CurrentNumber}");
        }

        void GuessNumber()
        {
            Console.Write("Higher or lower? ");
            _dealer._guess = Console.ReadLine();
            
        }
        
        void UserInput()
        {
            _dealer.DisplayCard();

           if (!_dealer.IsFirstTurn() && _score > 0)
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
            
            _dealer.CheckGuess(_dealer._guess);

            _score = _dealer._starting_score;
        }
        ///<summary>
        ///</summary>
        void DisplayScore()
        {
            UpdateScore();
            DisplayOutput();
        }
        void DisplayOutput()
        {
            if(_score > 0) 
            {                 
                        
            Console.WriteLine();
            Console.WriteLine($"Next card is: {_dealer._next_card_number}");
            Console.WriteLine($"Your score is: {_score}");
            }
            else if (_score <= 0)
            {
                Console.WriteLine("Your score is 0.");
                Gameover();
            }
        }

        void Gameover()
        {
            Console.WriteLine("Gameover. Better luck next time.");
        }

       
    } // end of class: Director
}
