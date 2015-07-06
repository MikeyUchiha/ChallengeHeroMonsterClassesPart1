using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 100;
            hero.DamageMaximum = 40;
            hero.AttackBonus = true;

            Character monster = new Character();
            monster.Health = 100;
            monster.DamageMaximum = 25;
            monster.AttackBonus = false;

            monster.Defend(hero.Attack());
            hero.Defend(monster.Attack());

            DisplayStats(hero);
            DisplayStats(monster);
        }

        private void DisplayStats(Character character)
        {
                character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }   
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int result = random.Next(DamageMaximum);
            return result;
        }

        public void Defend(int damage)
        {
            Health -= damage;
        }
    }
}