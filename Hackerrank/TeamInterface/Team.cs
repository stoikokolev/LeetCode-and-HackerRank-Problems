namespace TeamInterface
{
    public class Team
    {
        public Team(string name, int noOfPlayers)
        {
            this.teamName = name;
            this.noOfPlayers = noOfPlayers;
        }

        public string teamName { get; protected set; }

        public int noOfPlayers { get; private set; }

        public void AddPlayer(int count)
        {
            this.noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            if (count > this.noOfPlayers)
            {
                return false;
            }

            this.noOfPlayers -= count;
            return true;
        }
    }
}