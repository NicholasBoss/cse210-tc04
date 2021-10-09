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
        public int CheckScore(int _score)
        {
            
            if (_increase_score == true)
            {
                _score += 100;
            }
            else if (_increase_score == false)
            {
                _score = _score - 75;
            }
            return _score;
        }

        ///<summary>
        ///</summary>
        public void PointsPerCard()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///</summary>
        public string DisplayCards()
        {
            throw new NotImplementedException();
        }
    }
}