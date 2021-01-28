using System;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = text.Length;
            char punch = '>';
            string textLeft = "";
            bool punched = false;
            int strength = 0;            
            
            for (int i = 0; i < length; i++)
            {
                if (text[i] == punch)
                {
                    punched = true;
                    textLeft += text[i];
                    strength += int.Parse(text[i + 1].ToString());
                }
                else if (!punched && strength >= 0)
                {
                    textLeft += text[i];
                }
                else
                {
                    strength--;
                }
                if (strength == 0)
                {
                    punched = false;
                }
            }
            Console.WriteLine(textLeft);
        }
    }
}
