class Game
{
    int playerNumber;

    Player[] players=new Player[5];
    public Game(int inputPlayerNumber)
    {
        playerNumber=inputPlayerNumber;

        Console.WriteLine("How many human players do you want (max 5)");
        int humanPlayers=Convert.ToInt32(Console.ReadLine());

        int computerPlayers=5-humanPlayers;

        for(int i=0;i<5;i++)
        {
            if(i<humanPlayers)
            {
                players[i]=new HumanPlayer();
            }
            else
            {
                players[i]=new ComputerPlayer();
            }
        }
    }

    public void GameRun()
    {
        while(!CheckWin())
        {
            Round();
        }
        Console.WriteLine("Game end");
    }

    private void Round()
    {

    }

    private bool CheckWin()
    {
        for(int i=0;i<5;i++)
        {
            if(players[i].diceNum<1)
            {
                Console.WriteLine($"player {i} won");
                return true;
            }
        }
        return false;
    }
}