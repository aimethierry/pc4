using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SecretCombi
    {
        //Fields and Properties
        private int[] secret = new int[4];
        private Random rand = new Random();

        public int[] Secret
        {
            get { return secret; }
        }
        //Constructors
        public SecretCombi()
        {
            for (int i = 0; i < 4; i++)
            {
                int nextNumber;

                do { nextNumber = rand.Next(1, 10);}
                while (secret.Contains(nextNumber)) ;

                secret[i] = nextNumber;
            }
        }
        //Methods
        public bool Compare(int[] guess,out int score1,out int score2) 
        {
            score1 = 0;
            score2 = 0;
            for (int i = 0; i < 4; i++)
            {
                if (secret[i] == guess[i])
                {
                    score1++;
                    
                }else if (secret.Contains(guess[i]))
                {
                    score2++;
                }
            }

            if (score1 == 4 && score2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
