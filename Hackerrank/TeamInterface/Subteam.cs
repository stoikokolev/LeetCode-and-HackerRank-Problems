namespace TeamInterface
{
    public class Subteam : Team
    {
        public Subteam(string name, int noOfPlayers)
            : base(name, noOfPlayers)
        {

        }

        public void ChangeTeamName(string name)
        {
            this.teamName = name;
        }
    }
}