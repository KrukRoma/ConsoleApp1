namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("It`s easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");

            //2
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int num5 = int.Parse(Console.ReadLine());

            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            if (num4 < min)
            {
                min = num4;
            }
            if (num5 < min)
            {
                min = num5;
            }
            Console.WriteLine(min);


        }
    }
}