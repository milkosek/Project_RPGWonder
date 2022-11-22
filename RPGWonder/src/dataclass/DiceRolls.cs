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
        private Dictionary<int, int> diceDict = new Dictionary<int, int>();
        public DiceRolls(List<int> dice) 
        {
            for (int iter = 0; iter < dice.Count; iter += 2)
            {
                diceDict.Add(dice[iter + 1], dice[iter]);
            }

            foreach (KeyValuePair<int, int> kvp in diceDict)
            {
                Debug.WriteLine("k {0} n {1}", kvp.Key, kvp.Value);
            }
        }

        public void Roll()
        {
            Random randomizer = new Random();

            foreach (KeyValuePair<int, int> die in diceDict)
            {
                for (int iter = 0; iter < die.Value; iter++)
                {
                    Debug.WriteLine("k{0}: {1}", die.Key, randomizer.Next(1, die.Key + 1));
                }
            }
        }

        public void addDie(int k)
        {
            if (diceDict.ContainsKey(k))
            {
                diceDict[k]++;
            }
            else
            {
                diceDict.Add(k, 1);
            }
        }

        public void subDie(int k)
        {
            if (diceDict.ContainsKey(k))
            {
                if (diceDict[k] > 0)
                {
                    diceDict[k]--;
                }
            }
        }
    }

}
