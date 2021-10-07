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
            throw new NotImplementedException();
        }

        ///<summary>
        ///<summary>
        public void CheckScore()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///<summary>
        public void PointsPerCard()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///<summary>
        public void DisplayCards()
        {
            throw new NotImplementedException();
        }
    }
}