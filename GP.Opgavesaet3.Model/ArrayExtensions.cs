using System;

namespace GP.Opgavesaet3.Model
{
    public static class ArrayExtensions
    {
        public static T[] Reversed<T>(this T[] array)
        {
            var reversedArray = new T[array.Length];
            for (var i = 0; i < array.Length; i++)
                reversedArray[array.Length - i - 1] = array[i];
            return reversedArray;
        }

        public static T[] SubArray<T>(this T[] array, int startPos, int count)
        {
            var subArray = new T[count];
            for (var i = 0; i < count; i++)
            {
                subArray[i] = array[startPos + i];
            }
            return subArray;
        }

        public static T[] OnlyAboveOrBelowMinAndMax<T>(this T[] array, T min, T max) where T : IComparable
        {
            var count = 0;
            for (var i = 0; i < array.Length; i++)
                if (ItemIsWithinMinAndMax(array[i], min, max)) count++;
            var result = new T[count];
            var currentPosInResult = 0;
            for (var i = 0; i < array.Length; i++)
                if (ItemIsWithinMinAndMax(array[i], min, max)) result[currentPosInResult++] = array[i];
            return result;
        }

        private static bool ItemIsWithinMinAndMax<T>(T item, T min, T max) where T : IComparable
        {
            return (item.CompareTo(min) >= 0) && (item.CompareTo(max) <= 0);
        }

        public static int OccurrencesOf<T>(this T[] array, T kind)
        {
            var numberOfKind = 0;
            for (var i = 0; i < array.Length; i++)
                if (array[i].Equals(kind)) numberOfKind++;
            return numberOfKind;
        }

        public static int FirstPositionOf<T>(this T[] array, T kind)
        {
            for (var i = 0; i < array.Length; i++)
                if (array[i].Equals(kind)) return i;
            throw new ArgumentException("No first occurrence of kind", nameof(kind));
        }
    }
}
