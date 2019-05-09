using System;
using System.ComponentModel.Design;
using System.Linq;

namespace Game
{
    class SecretCombi
    {
        private int[] secretcomb = new int[4];
        private int i;

        public delegate void LostGame(string info);

        public event LostGame YouLost;

        public SecretCombi()
        {
            GenerateDigits(); i = 0;
        }

        private void GenerateDigits()
        {

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int guess = rand.Next(1, 10);
                while (secretcomb.Contains(guess))
                {
                    guess = rand.Next(1, 10);

                }

                secretcomb[i] = guess;
            }

        }

       
        public bool guess(int[] x, out int score1, out int score2,ref int credits)
        {
            score1 = 0;
            score2 = 0;
            i++;

            if (i <= 10)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (x[i] == secretcomb[i])
                    {
                        score1++;
                    }
                    else if (secretcomb.Contains(x[i]))
                    {
                        score2++;

                    }
                }
               
                if (score1 == 4 && score2 == 0)
                {
                    return true;
                }
                if (score1+score2 >= 3)
                {
                    credits-= 5;
                }
                else if (score1+score2 >= 1)
                {
                    credits -= 10;

                }
                else if(score1+score2 == 0)
                {
                    credits -= 15;
                }
                
            }
            else
            {
                YouLost?.Invoke("You lost, the Combo was: " + string.Join(",", secretcomb)+" and your credits are: "+credits);
            }


            return false;
        }
    }
}
