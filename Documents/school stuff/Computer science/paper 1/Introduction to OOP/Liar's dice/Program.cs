class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your player number");
        int playerNumber=Convert.ToInt32(Console.ReadLine());

        while(playerNumber<2||playerNumber>5)
        {
            Console.WriteLine("Invalid number. Enter between 2 and 5");
            playerNumber=Convert.ToInt32(Console.ReadLine());
        }
        
        Game game=new Game(playerNumber);

        game.GameRun();
    }
}