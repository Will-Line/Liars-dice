class Player
{
    private Cup cup;
    public int diceNum;

    public void NewCup(int diceNumber)
    {
        diceNum=diceNumber;
        cup=new Cup(diceNumber);
        cup.rollDie();
    }

    public Bet MakeBet(Bet lastBet, int gameDiceLeft)
    {
        Bet bet = new Bet();
        return bet;
    }

    private bool CheckValidBet(Bet lastBet, int gameDiceLeft)
    {

    }
}