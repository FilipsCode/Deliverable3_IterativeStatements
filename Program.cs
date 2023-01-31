namespace Deliverable_3IterativeStatements;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Enter an integer number between 1 and 100");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Specify the series type: Even or Odd");
        string series = Console.ReadLine();

        for (int i = -1; i < input; i = i + 2) ;
        {
            Console.WriteLine(i);
        }
        
    }
}

