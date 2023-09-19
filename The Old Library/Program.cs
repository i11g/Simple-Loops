namespace The_Old_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorateBook = Console.ReadLine();
            
            string bookName=Console.ReadLine();

            int numberOfBooksChecked = 0;
            bool isChecked=false;

            while(favorateBook!=bookName)
            {
                numberOfBooksChecked++;
                bookName= Console.ReadLine();
                if(bookName== "No More Books")
                {
                    isChecked = true;
                    break;
                }
            }
            if(isChecked)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooksChecked} books.");
            }
            else
            {
                Console.WriteLine($"You checked {numberOfBooksChecked} books and found it");
            }
        }
    }
}