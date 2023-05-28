namespace Football
{
    internal class Goal
    {
        private FootballPlayer player;
        private int minute;
        public FootballPlayer Player
        {
            get { return this.player; }
            set { this.player = value; }
        }
        public int Minute
        {
            get { return this.minute; }
            set { this.minute = value; }
        }
        public Goal(FootballPlayer player, int minute)
        {
            this.player = player;
            this.minute = minute;
        }
        public string ToString()
        {
            return $"{Player.Name} scores in {Minute} minute!";
        }

    }
}