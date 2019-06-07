using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
     class Combat
    {
        List<NPC> enemies;
        Player p;
        Enemy en;
        Random ran = new Random();
        public Combat(Player p)
        {
            this.p = p;
        }
        public void createCombat()
        {

            p.inCombat = true;
            en = new Enemy("basic bitch", 5, 1);
            
            p.render("You enter combat with " + en.name);

        }

        public void endCombat()
        {

        }

        public void basicAttack(Combatant attacker, Combatant defender)
        {
            int precision = attacker.precision;
            int evasion = defender.evasion;

        }

        static void renderStats()
        {
            
        }





    }
}
