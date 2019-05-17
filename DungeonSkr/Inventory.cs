using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    class Inventory
    {
        List<Weapon> PlayersWeapons;
        List<Consumable> PlayersConsumables;
        List<Augment> PlayersAugments;
        List<Wearable> PlayersWearables;

        public Inventory()
        {
            this.PlayersWeapons = new List<Weapon>();
            this.PlayersConsumables = new List<Consumable>();
            this.PlayersAugments = new List<Augment>();
            this.PlayersWearables = new List<Wearable>();
        }
        //Ich schreibe nicht 24 konstruktorn für jeden fall was es an listen gibt und was nicht
        public Inventory(List<Weapon> PlayersWeapons, List<Consumable> PlayersConsumables,List<Augment> PlayersAugments,List<Wearable> PlayersWearables)
        {
            this.PlayersWeapons = PlayersWeapons;
            this.PlayersConsumables = PlayersConsumables;
            this.PlayersAugments = PlayersAugments;
            this.PlayersWearables = PlayersWearables;
        }
        public Inventory(Weapon Weap, Consumable Con, Augment Aug, Wearable Wear)
        {
            PlayersWeapons.Add(Weap);
            PlayersConsumables.Add(Con);
            PlayersAugments.Add(Aug);
            PlayersWearables.Add(Wear);
        }
      
        public List<Weapon> AddWeapon(Weapon w)
        {
            PlayersWeapons.Add(w);
            return PlayersWeapons;
        }
        public List<Consumable> AddConsumable(Consumable c)
        {
            PlayersConsumables.Add(c);
            return PlayersConsumables;
        }
        public List<Augment> AddAugment(Augment a)
        {
            PlayersAugments.Add(a);
            return PlayersAugments;
        }
        public List<Wearable> AddWearable(Wearable w)
        {
            this.PlayersWearables.Add(w);
            return PlayersWearables;
        }
    }
}
