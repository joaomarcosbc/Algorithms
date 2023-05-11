namespace SelectionSort
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            for ( var i = 0; i < array.Length ; i++ )
            {
                var min = i;

                for ( var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                (array[i], array[min]) = (array[min], array[i]);
            }

            return array;
        }
    }
}
