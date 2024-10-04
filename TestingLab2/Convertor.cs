namespace TestingLab2
{
    public class Convertor
    {
        public static int NumberConvertor(int number, int notation)
        {
            if (notation < 2 || notation > 9 || number <= 0)
            {
                return 0;
            }

            string result = "";
            while (number > 0)
            {
                int remainder = number % notation;
                result = remainder + result;
                number /= notation;
            }

            return int.Parse(result);
        }
    }
}
