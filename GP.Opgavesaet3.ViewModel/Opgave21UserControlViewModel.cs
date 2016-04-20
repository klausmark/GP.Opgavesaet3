using System;
using GP.Opgavesaet3.Model;

namespace GP.Opgavesaet3.ViewModel
{
    public class Opgave21UserControlViewModel : NotifyBase
    {
        private const int AmountOfRandomNumbers = 50;
        public Opgave21Solution _opgave21Solution;
        public Opgave21UserControlViewModel()
        {
            _opgave21Solution = new Opgave21Solution();

            RandomNumbers = _opgave21Solution.GetThisAmountOfRandomNumbers(AmountOfRandomNumbers);
            RandomNumbersReversed = RandomNumbers.Reversed();

            LowestNumbers = 0;
            HighestNumbers = 100;

            SectionFrom = 0;
            SectionTo = AmountOfRandomNumbers - 1;

            Number = RandomNumbers[AmountOfRandomNumbers - 1];
        }

        public int[] RandomNumbers { get; }

        public int[] RandomNumbersReversed { get; }

        public int[] SectionOfRandomNumbers
        {
            get { return GetField<int[]>(); }
            set { SetField(value); }
        }

        public int SectionFrom
        {
            get { return GetField<int>(); }
            set { SetFieldAndInvokeMethod(value, SectionChanged); }
        }

        public int SectionTo
        {
            get { return GetField<int>(); }
            set { SetFieldAndInvokeMethod(value, SectionChanged); }
        }

        private void SectionChanged()
        {
            try
            {
                SectionOfRandomNumbers = RandomNumbers.SubArray(SectionFrom, SectionTo - SectionFrom + 1);
            }
            catch (Exception)
            {
                SectionOfRandomNumbers = new int[0];
            }
        }

        public int[] AboveAndBelovLowestAndHigestNumbers
        {
            get { return GetField<int[]>(); }
            set { SetField(value); }
        }

        public int LowestNumbers
        {
            get { return GetField<int>(); }
            set { SetFieldAndInvokeMethod(value, LowHighNumbersChanged); }
        }

        public int HighestNumbers
        {
            get { return GetField<int>(); }
            set { SetFieldAndInvokeMethod(value, LowHighNumbersChanged); }
        }

        private void LowHighNumbersChanged()
        {
            AboveAndBelovLowestAndHigestNumbers = RandomNumbers.OnlyAboveOrBelowMinAndMax(LowestNumbers, HighestNumbers);
        }

        public int Number
        {
            get { return GetField<int>(); }
            set { SetFieldAndInvokeMethod(value, NumberChanged); }
        }

        private void NumberChanged()
        {
            OccurrencesOfNumber = _opgave21Solution.FindAntal(RandomNumbers, Number);
            FirstOccurrenceOfNumber = _opgave21Solution.FindForste(RandomNumbers, Number);
        }

        public int OccurrencesOfNumber
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }

        public int FirstOccurrenceOfNumber
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }
    }
}