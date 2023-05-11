namespace Algorithms
{

    using BinarySearch;
    using SelectionSort;

    class Program
    {
        public static void Main(string[] args)
        {

            // Thats my PlayGround :)

            int[] array = { 5, 3, 7, 10, 2, 11 };

            var sortedArrar = SelectionSort.Sort(array);

            for (int i = 0; i < sortedArrar.Length; ++i)
                Console.Write(sortedArrar[i] + " ");
            Console.WriteLine();
        }
    }
}