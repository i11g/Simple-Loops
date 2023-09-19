namespace Element_That_Equals_to_the_Sum_Of_the_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            double sum = 0;
            bool isEqual = false;

            for (int i = 0; i < number; i++)
            {
                int currentNumber=int.Parse(Console.ReadLine()) ;
                

                if ( currentNumber> maxNumber )
                {
                    maxNumber = currentNumber ;
                }

                sum += currentNumber;

                
            }
            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum-maxNumber}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"{Math.Abs(sum - maxNumber)-maxNumber}");
            }

        }
    }
}