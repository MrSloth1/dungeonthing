using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    abstract class Item
    {
       string name;
       string description;
       

    }
    public enum WeaponClass
    {
        Axe, Sword, Dagger, Shield
    }
    public enum Food //evtl nicht in ein enum
    {
        Apple, Raw_Meat, Mushroom, Leaf, Berry, Grape, 
    }
    public enum Consumableeffect
    {
       Runspeed_Boost, Healthregeneration, AttackDmgUp, AttackSpeedUp, None
    }
    public enum Wearableeffect
    {
       Agility, Runspeed_Boost, AttackDmgUp, AttackSpeedUp, DefenseUp, None 
    }
    public override class Consumable : Item
    {
        public Consumableeffect CEffect;
        public Consumable()
        {

        }
        public Consumable(Consumableeffect CEffect)
        {
            this.CEffect = CEffect;
        }

    }
    public override class Weapon : Item
    {
        public WeaponClass WeapClass;

        public Weapon()
        {
        }
        public Weapon(WeaponClass WeapClass)
        {
            this.WeapClass = WeapClass;
        }
    

    }
    public enum Augmenttype
    {

    }
    public override class Augment : Item
    {
        public int Supportduration;
        public Augmenttype AType;

        public Augment()
        {

        }
        public Augment(int Sduration, Augment AType)
        { 
        }
        //Leon ich hab kein Plan wie du das hier meinst
    }
    public override class Wearable : Item
    {
        public Color ClothingColor;
        public Wearableeffect[] WEffect;
        public Wearable()
        {

        }
        public Wearable(Wearableeffect Weffect)
        {
            this.WEffect = Weffect;
        }
    }
}
