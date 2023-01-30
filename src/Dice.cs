internal class Dice
{
    internal int Roll()
    {
        Random rnd = new Random();
        return rnd.Next(5) + 1;
    }
    internal int[] Roll(int diceCount)
    {
        int[] result= new int[diceCount];
        for (int i=0; i<diceCount; i++)
        {
            result[i] = Roll();
        }
        Array.Sort(result);
        return result;
    }
}
