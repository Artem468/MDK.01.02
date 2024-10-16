namespace TestingLab2
{
    public class Convertor
    {
        public static int[,]? FromArrayToMatrix(int[] array, int size = 4)
        {
            if (size <= 0)
            {
                return null;
            }

            int[,] result = new int[size, size];
            int length = array.Length;

            for (int i = 0; i < size * size; i++)
            {
                if (i < length)
                {
                    result[i / size, i % size] = array[i];
                }
                else
                {
                    result[i / size, i % size] = 0;
                }
            }

            return result;
        }
    }
}