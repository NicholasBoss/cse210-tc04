using System;
using System.Collections.Generic;

namespace cse210_tc04
{   

    /// <summary>
    /// The dealer is responsible for managing the deals which include: 
    /// Showing the card
    /// managing point assignment
    /// </summary>
    class Dealer
    {
        ///<summary>
        /// Member variables go here:
        ///</summary>
        const int NUM_CARDS = 13;
        List<int> _cards = new List<int>();
        public int _numDeals;
        public string _guess;
        public int _current_card_number;
        public bool _increase_score;
        public int _score = 0;


        ///<summary>
        /// Checks to see if it is the first turn
        ///</summary>
        public bool IsFirstTurn()
        {
            return _numDeals == 0;
        }

        ///<summary>
        /// The ResetDeal method handles the clearing of the deal of cards and
        /// generates the next card in the deal.
        ///</summary>
        public void ResetDeal()
        {
            _numDeals++;
            _cards.Clear();
            Random randomGenerator = new Random();
            
            int card = randomGenerator.Next(1,14);
            _cards.Add(card);
        }

        ///<summary>
        ///</summary>
        public void CheckGuess()
        {
            int _numguess;
            if (_guess == "l")
            {
                _numguess = 0;
                if (_numguess < _current_card_number)
                {
                    _increase_score = true;
                    CheckScore(_score);
                }
                else if (_numguess > _current_card_number)
                {
                    _increase_score = false;
                    CheckScore(_score);
                }
            }
            if (_guess == "h")
            {
                _numguess = 15;
                if (_numguess > _current_card_number)
                {
                    _increase_score = true;
                    CheckScore(_score);
                }
                else if (_numguess < _current_card_number)
                {
                    _increase_score = false;
                    CheckScore(_score);
                }
            }
            
        }
    
        ///<summary>
        ///</summary>
        public int CheckScore(int score)
        {
            score = 0;
            if (_increase_score == true)
            {
                score += 100;
            }
            else if (_increase_score == false)
            {
                score = score - 75;
            }
            return score;
        }

        ///<summary>
        /// This function make the score by usingCheckScore function 
        ///</summary>
        public int PointsPerCard()
        {
            int score = 0;
            int guessNum = int.Parse(_guess);
            score += CheckScore(guessNum);

            return score;
        }

        ///<summary>
        /// This function generate next card
        ///</summary>
        public string DisplayCards()
        {     
            Random randomGenerator = new Random();
            
            string NextCard = randomGenerator.Next(1,14).ToString();

            return NextCard;
        }
    }
}