class Dice
{
    private int diceValue;
    public int DiceValue{ get; }

    public void RollDice()
    {
        Random random=new Random();

        diceValue=random.Next(1,7);
    }
}