using System;
using System.Text;

namespace DreamVB.RndPassword
{
    public class RandomPassword
    {
        private readonly Random _rand;

        public bool Uppercase { get; set; }
        public bool Lowercase { get; set; }
        public bool Numbers { get; set; }
        public bool Special { get; set; }
        public int Length { get; set; }

        public RandomPassword()
        {
            _rand = new Random();
            Length = 4;
            Uppercase = true;
            Lowercase = true;
            Numbers = true;
        }

        public string Generate()
        {
            StringBuilder pwsmask = new StringBuilder();
            StringBuilder ret = new StringBuilder();
            int x = 0;
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string number = "0123456789";
            const string special = "!@#$%^&*_-=+";

            try
            {
                if (Uppercase)
                {
                    pwsmask.Append(upper);
                }
                if (Lowercase)
                {
                    pwsmask.Append(lower);
                }
                if (Numbers)
                {
                    pwsmask.Append(number);
                }
                if (Special)
                {
                    pwsmask.Append(special);
                }

                while (x < Length)
                {
                    //Get next random number
                    int r = _rand.Next(pwsmask.Length);
                    //Make random password
                    ret.Append(pwsmask[r]);
                    //Inc counter
                    x++;
                }
                pwsmask.Clear();
                //Return random password.
                return ret.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
