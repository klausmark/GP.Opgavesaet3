using System;

namespace GP.Opgavesaet3.Model
{
    public class Opgave31Solution
    {
        public Int32 Minimum(Int32[] tabel)
        {
            if (tabel.Length == 0) return -1;
            if (tabel.Length == 1) return tabel[0];

            var minimum = tabel[0];
            for (int i = 1; i < tabel.Length; i++)
                if (tabel[i] < minimum) minimum = tabel[i];

            return minimum;
        }

        public Int32 Maximum(Int32[] tabel)
        {
            if (tabel.Length == 0) return -1;
            if (tabel.Length == 1) return tabel[0];

            var maximum = tabel[0];
            for (int i = 1; i < tabel.Length; i++)
                if (tabel[i] < maximum) maximum = tabel[i];

            return maximum;
        }

        public Int32 Sum(Int32[] tabel)
        {
            var sum = 0;
            for (int i = 0; i < tabel.Length; i++)
                sum += tabel[i];

            return sum;
        }

        public double Gennemsnit(Int32[] tabel)
        {
            return Sum(tabel)/(double) tabel.Length;
        }
    }
}