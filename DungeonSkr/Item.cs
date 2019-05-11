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
       
    }
    public enum WeaponClass
    {
        Axe, Sword, Dagger,
    }
    public enum Food
    {
        Apple, Raw_Meat, Mushroom, Leaf, Berry, Grape,   
    }
    public enum effect
    {
       Runspeed_Boost, Healthregeneration, AttackDmgUp, AttackSpeedUp, 
    }
    public override class Consumable : Item
    {
        public effect ConsumableEffect;
        public Consumable()
        {

        }

    }
    public override class Weapon : Item
    {
        public WeaponClass WeapClass;

        public Weapon()
        {

        }

    }
    public override class Augment : Item
    {
        //Leon ich hab kein Plan wie du das hier meinst
    }
    public override class Wearable : Item
    {
        public Color ClothingColor;
        public Wearable()
        {

        }
    }
    

}
