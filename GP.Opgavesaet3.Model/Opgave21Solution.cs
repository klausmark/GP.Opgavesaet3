using System;

namespace GP.Opgavesaet3.Model
{
    public class Opgave21Solution
    {
        public int[] GetThisAmountOfRandomNumbers(int amount)
        {
            var random = new Random();
            var numbers = new int[amount];
            for (var i = 0; i < amount; i++)
            {
                numbers[i] = random.Next(0, 100);
            }
            return numbers;
        }

        public Int32 FindAntal(Int32[] tabel, Int32 tal)
        {
            return tabel.OccurrencesOf(tal);
        }

        public Int32 FindForste(Int32[] tabel, Int32 tal)
        {
            try
            {
                return tabel.FirstPositionOf(tal);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}