using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    class Player
    {
        Inventory PlayerInventory = new Inventory(new List<Weapon>(),new List<Consumable>(),new List<Augment>(),new List<Wearable>());
        int health;
        Weapon EquippedWeapon;
        Wearable[] EquippedWearables;
        
        public void ChangeWeapon(Weapon w)
        {

            EquippedWeapon = w;
        }

        
    }
}
