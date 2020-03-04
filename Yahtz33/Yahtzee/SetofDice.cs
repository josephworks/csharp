namespace Yahtzee
{
    internal class SetofDice
    {
        private Dice[] d = new Dice[5];

        public void Roll()
        {
            for (int i = 0; i < d.Length; i++)
            {
                d[i].Roll();
            }
        }

        public int score()
        {
            return d[1].Value() + d[2].Value() + d[3].Value() + d[4].Value() + d[5].Value();
        }
    }
}