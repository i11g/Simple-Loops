namespace Numbers_Uo_To_1000_end_by_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <1000 ; i+=10)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <1000 ; i++)
            {
                if(i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}