class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your player number");
        Game game=new Game(Convert.ToInt32(Console.ReadLine()));
    }
}