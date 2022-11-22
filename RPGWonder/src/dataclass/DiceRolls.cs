using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder
{
    class DiceRolls
    {
        /// <summary>
        /// <c>DiceDict</c> dictionary representing all dice in a form (number of dice, faces of dice).
        /// </summary>
        private Dictionary<int, int> DiceDict = new Dictionary<int, int>();
        private Random Randomizer = new Random();
        public DiceRolls(){}

        /// <summary>
        /// <c>DiceRolls</c> constructor with a list of dice to add to <c>DiceDict</c>.
        /// </summary>
        /// <param name="dice">Initial list of dice.</param>
        public DiceRolls(List<int> dice) 
        {
            for (int iter = 0; iter < dice.Count; iter += 2)
            {
                DiceDict.Add(dice[iter + 1], dice[iter]);
            }

            foreach (KeyValuePair<int, int> kvp in DiceDict)
            {
                Debug.WriteLine("k {0} n {1}", kvp.Key, kvp.Value);
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

            foreach (KeyValuePair<int, int> die in DiceDict)
            {
                for (int iter = 0; iter < die.Value; iter++)
                {
                    TempRoll = Randomizer.Next(1, die.Key + 1);

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
        /// <c>AddDie</c> function increases the number of k sided dice in <c>DiceDict</c> by 1.
        /// </summary>
        /// <param name="k">Number of faces on a die.</param>
        public void AddDie(int k)
        {
            if (k > 0)
            {
                if (DiceDict.ContainsKey(k))
                {
                    DiceDict[k]++;
                }
                else
                {
                    DiceDict.Add(k, 1);
                }
            }
        }

        /// <summary>
        /// <c>AddDie</c> function decreases the number of k sided dice in <c>DiceDict</c> by 1.
        /// </summary>
        /// <param name="k">Number of faces on a die.</param>
        public void SubDie(int k)
        {
            if (DiceDict.ContainsKey(k))
            {
                if (DiceDict[k] > 0)
                {
                    DiceDict[k]--;
                }
            }
        }

        /// <summary>
        /// <c>StringDie</c> function converts <c>DiceDict</c> to a <c>string</c>. 
        /// </summary>
        /// <returns>
        /// A <c>string</c> representing all dice, in a form: 
        /// "{number od dice}k{faces of dice}" separated by spaces.
        /// </returns>
        public String StringDie()
        {
            String dieStr = "";

            foreach (KeyValuePair<int, int> die in DiceDict)
            {
                dieStr += String.Format(" {0}k{1}", die.Value, die.Key);
            }

            return dieStr;
        }

        /// <summary>
        /// <c>QuickRoll</c> function converts <c>DiceDict</c> to a <c>string</c> in a form: 
        /// "{number od dice}k{faces of dice}" separated by spaces.
        /// </summary>
        /// <param name="k">Number of faces on a die.</param>
        /// <returns>
        /// Roll result as an <c>Int</c>.
        /// </returns>
        public int QuickRoll(int k)
        {
            return Randomizer.Next(1, k + 1);
        }
    }

}
