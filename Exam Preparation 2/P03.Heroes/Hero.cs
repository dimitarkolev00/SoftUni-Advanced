using System.Text;

namespace Heroes
{
    public class Hero
    {
        
        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;

        }
        public string Name { get; set; }

        public int Level { get; set; }
        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Hero: {this.Name} – {this.Level}lvl")
                .AppendLine("Item:")
                .AppendLine($"  * Strength: {this.Item.Strength}")
                .AppendLine($"  * Ability: {this.Item.Ability}")
                .AppendLine($"  * Intelligence: {this.Item.Intelligence}");


            return sb.ToString().TrimEnd();
        }
    }
}
