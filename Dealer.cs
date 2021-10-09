using System;
using System.Collections.Generic;

namespace cse210_tc04
{   

    /// <summary>
    /// The dealer is responsible for managing the deals which include: 
    /// Showing the card
    /// managing point assignment
    
    /// <summary>
    class Dealer
    {
        ///<summary>
        /// Member variables go here:
        ///<summary>
        const int NUM_CARDS = 13;
        List<int> _cards = new List<int>();
        public int _numDeals;
        public string _guess;
        int _current_card_number;
        bool _increase_score;

        ///<summary>
        ///<summary>
        public bool IsFirstTurn()
        {
            return _numDeals == 0;
        }

        ///<summary>
        ///<summary>
        public void ResetDeal()
        {
            _numDeals++;
            _cards.Clear();
            Random randomGenerator = new Random();
            
            for (int i = 0; i < NUM_CARDS; i++)
            {
                int card = randomGenerator.Next(1,14);
                _cards.Add(card);
            }
        }

        ///<summary>
        ///<summary>
        public void CheckGuess()
        {
            int _numguess;
            if (_guess == "l")
            {
                _numguess = 0;
                if (_numguess < _current_card_number)
                {
                    _increase_score = true;
                    CheckScore();
                }
                if (_numguess > _current_card_number)
                {
                    _increase_score = false;
                    CheckScore();
                }
            }
            if (_guess == "h")
            {
                _numguess = 15;
                if (_numguess > _current_card_number)
                {
                    _increase_score = true;
                    CheckScore();
                }
                if (_numguess < _current_card_number)
                {
                    _increase_score = false;
                    CheckScore();
                }
            }
            
        }
    
        ///<summary>
        ///<summary>
        public void CheckScore()
        {
            if (_increase_score == true)
            {
                _score += 100;
            }
            if (_increase_score == false)
            {
                _score = _score - 75;
            }
        }

        ///<summary>
        ///<summary>
        public void PointsPerCard()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///<summary>
        public string DisplayCards()
        {
            throw new NotImplementedException();
        }
    }
}