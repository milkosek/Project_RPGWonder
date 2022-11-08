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
        public void Roll(int n, int k)
        {
            Random randomizer = new Random();

            for (int iter = 0; iter > n; iter--)
            {
                Debug.WriteLine("test {0}", randomizer.Next(1, k + 1));
            }
        }
    }

    //private void HandleRoll(object sender, System.EventArgs e)
    //{
    //    DiceRolls roller = new DiceRolls();
    //    roller.Roll(2, 6);
    //}
}
