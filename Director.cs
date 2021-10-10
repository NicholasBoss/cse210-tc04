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
                CurrentNumber();
                GuessNumber();
                DisplayScore();
                UserInput();
                
            }
            Gameover();
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
            _dealer.CheckGuess(_dealer._guess);
        }
        
        void UserInput()
        {
            _dealer.DisplayCard();

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

            _dealer.CheckGuess(_dealer._guess);

            _dealer.CheckScore(_dealer._score);
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

            string cardString = _dealer.DisplayCard();

            _dealer.DisplayCard();


            Console.WriteLine();
            Console.WriteLine($"Next card was: {_dealer._current_card_number}");
            Console.WriteLine($"Your score is: {_dealer._score}");
        }

        void Gameover()
        {
            Console.WriteLine("Gameover");
        }

       
    } // end of class: Director
}
