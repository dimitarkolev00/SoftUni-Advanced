using System.Text;

namespace Guild
{
    public class Player
    {
        private Player()
        {
            this.Rank = "Trial";
            this.Description = "n/a";
        }
        public Player(string name , string clas)
        {
            this.Name = name;
            this.Class = clas;
        }
       
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get { return this.Rank = "Trial"; } set { } }
        public string Description { get { return this.Description = "n/a"; } set { } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Player { this.Name}: { this.Class}")
                .AppendLine($"Rank: {this.Rank}")
                .AppendLine($"Description: {this.Description}");

            return sb.ToString().TrimEnd(); ;
        }
    }
}
