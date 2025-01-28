class Cup
{
    public Dice[] diceArray;

    public Cup(int diceNumber)
    {
        diceArray=new Dice[diceNumber];
    }

    public void rollDie()
    {
        for(int i=0;i<diceArray.Length;i++)
        {
            diceArray[i].RollDice();
        }
    }
}