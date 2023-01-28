using System;
using System.Collections.Generic;

namespace RPGWonder
{
    class DiceRolls
    {
        /// <summary>
        /// <c>DiceDict</c> dictionary representing all dice in a form (number of dice, faces of dice).
        /// </summary>
        private Dictionary<int, int> _discDict = new Dictionary<int, int>();
        private Random _randomizer = new Random();

        public DiceRolls()
        {

        }

        public int Count()
        {
            return _discDict.Count;
        }

        /// <summary>
        /// <c>DiceRolls</c> constructor with a list of dice to add to <c>DiceDict</c>.
        /// </summary>
        /// <param name="dice">Initial list of dice.</param>
        public DiceRolls(List<int> dice) 
        {
            for (int iter = 0; iter < dice.Count; iter += 2)
            {
                _discDict.Add(dice[iter + 1], dice[iter]);
            }
        }

        /// <summary>
        /// <c>Roll</c> function rolls all dice from <c>DiceDict</c>.
        /// </summary>
        /// <returns>
        /// A dictionary representing all rolls, in the form (faces, List(results)).
        /// </returns>
        public Dictionary<int, List<int>> Roll()
        {
            Dictionary<int, List<int>> RollsDict = new Dictionary<int, List<int>>();

            int TempRoll;

            foreach (KeyValuePair<int, int> die in _discDict)
            {
                for (int iter = 0; iter < die.Value; iter++)
                {
                    TempRoll = _randomizer.Next(1, die.Key + 1);

                    if (RollsDict.ContainsKey(die.Key))
                    {
                        RollsDict[die.Key].Add(TempRoll);
                    }
                    else
                    {
                        RollsDict.Add(die.Key, new List<int>());
                        RollsDict[die.Key].Add(TempRoll);
                    }
                }
            }
            return RollsDict;
        }

        /// <summary>
        /// <c>AddDie</c> function increases the number of d sided dice in <c>DiceDict</c> by 1.
        /// </summary>
        /// <param name="d">Number of faces on a die.</param>
        public void AddDie(int d)
        {
            if (d > 0)
            {
                if (_discDict.ContainsKey(d))
                {
                    _discDict[d]++;
                }
                else
                {
                    _discDict.Add(d, 1);
                }
            }
        }

        /// <summary>
        /// <c>AddDie</c> function decreases the number of d sided dice in <c>DiceDict</c> by 1.
        /// </summary>
        /// <param name="d">Number of faces on a die.</param>
        public void SubDie(int d)
        {
            if (_discDict.ContainsKey(d))
            {
                if (_discDict[d] == 1)
                {
                    _discDict.Remove(d);
                }
                else if (_discDict[d] > 0)
                {
                    _discDict[d]--;
                }
            }
        }

        /// <summary>
        /// <c>StringDie</c> function converts <c>DiceDict</c> to a <c>string</c>. 
        /// </summary>
        /// <returns>
        /// A <c>string</c> representing all dice, in a form: 
        /// "{number od dice}d{faces of dice}" separated by spaces.
        /// </returns>
        public String StringDie()
        {
            String dieStr = "";

            foreach (KeyValuePair<int, int> die in _discDict)
            {
                dieStr += String.Format(" {0}d{1}", die.Value, die.Key);
            }

            return dieStr;
        }

        /// <summary>
        /// <c>QuickRoll</c> function rolls <c>n</c> <c>d</c>-sided dice. 
        /// </summary>
        /// <param name="n">Number of faces on a die.</param>
        /// <param name="d">Number of faces on a die.</param>
        /// <returns>
        /// Sum of rolls as an <c>Int</c>.
        /// </returns>
        public int QuickRoll(int n, int d)
        {
            int TempSum = 0;

            for (int i = 0; i < n; i++)
            {
                TempSum += _randomizer.Next(1, d + 1);
            }
            return TempSum;
        }

        public void Clear()
        {
            _discDict.Clear();
        }
    }

}
