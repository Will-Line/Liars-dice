class Game
{
    const int startingDiceNum=5;

    int playerNumber;

    Player[] players;
    public Game(int inputPlayerNumber)
    {
        playerNumber=inputPlayerNumber;
        players=new Player[inputPlayerNumber];

        Console.WriteLine("How many human players do you want (max 5)");
        int humanPlayers=Convert.ToInt32(Console.ReadLine());

        int computerPlayers=5-humanPlayers;

        for(int i=0;i<playerNumber;i++)
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
        int totalDiceLeft=players.Length*startingDiceNum;

        while(!CheckWin())
        {
            Round(totalDiceLeft);
        }
        Console.WriteLine("Game end");
    }

    private void Round(int totalDiceLeft)
    {
        Bet lastBet=new Bet();

        while(!lastBet.lie)
        {
            for(int i=0;i<playerNumber;i++)
            {
                lastBet=players[i].MakeBet(lastBet, totalDiceLeft);
                if(lastBet.lie)
                {
                    Console.WriteLine();
                    break;
                }
            }
        }
    }

    private bool CheckWin()
    {
        for(int i=0;i<playerNumber;i++)
        {
            if(players[i].diceNum<1)
            {
                Console.WriteLine($"player {i} won");
                return true;
            }
        }
        return false;
    }

    private string LieCalled()
    {
        
    }
}