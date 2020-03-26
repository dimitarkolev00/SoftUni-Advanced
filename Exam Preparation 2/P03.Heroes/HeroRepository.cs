using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private readonly List<Hero> data;
        public HeroRepository()
        {
            this.data = new List<Hero>();
        }
        public int Count => this.data.Count;
        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }
        public void Remove(string name)
        {
            Hero hero = this.data.FirstOrDefault(h => h.Name == name);
            this.data.Remove(hero);
        }
        public Hero GetHeroWithHighestStrength()
        {
            Hero heroWithHighestStrength = this.data.OrderByDescending(h => h.Item.Strength).First();
            return heroWithHighestStrength;
        }
        public Hero GetHeroWithHighestAbility()
        {
            Hero heroWithHighestAbility = this.data.OrderByDescending(h => h.Item.Ability).First();
            return heroWithHighestAbility;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroIntelligence = this.data.OrderByDescending(h => h.Item.Intelligence).First();

            return heroIntelligence;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in this.data)
            {
                sb.Append(hero);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
