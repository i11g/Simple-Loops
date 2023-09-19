namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGrades=int.Parse(Console.ReadLine());

            string problemName=Console.ReadLine();

            double sumOfGrades = 0;
            double numberOfProblems = 0;
            string lastProblem = "";
            int sumOfFailGrades = 0;

            while(problemName!="Enough")
            {
                double grades = double.Parse(Console.ReadLine());
                lastProblem = problemName;
                sumOfGrades += grades;
                numberOfProblems++;
                if(sumOfGrades<=4)
                {
                    sumOfFailGrades++;
                }
                if(sumOfFailGrades==numberOfPoorGrades)
                {
                    Console.WriteLine($"You need a break, {sumOfFailGrades} poor grades." );
                }
               problemName= Console.ReadLine();
               
            }
            Console.WriteLine($"Average score: {sumOfGrades / numberOfProblems:f2}");
            Console.WriteLine($"Number of problems:{numberOfProblems}");
            Console.WriteLine($"Last problem:{lastProblem}");
        }
    }
}