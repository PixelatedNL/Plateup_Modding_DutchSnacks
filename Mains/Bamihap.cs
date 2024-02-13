using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace KitchenDutchSnacks.Mains
{
    class Bamihap : CustomItem
    {
        public override string UniqueNameID => "Bamihap";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bamihap");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.ExtraLarge;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 10.0f,
                Process = Refs.Cook,
                IsBad = true,
                Result = Refs.Burnt
            }
        };

        public override void OnRegister(Item item)
        {
            Prefab.ApplyMaterialToChild("Pancake.001", "Raw Pastry", "Onion");
        }
    }
}
