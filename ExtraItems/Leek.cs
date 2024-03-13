using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenDutchSnacks.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KitchenDutchSnacks.Mains
{
    class Leek : CustomItem
    {
        public override string UniqueNameID => "LeekCustomItem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Leek Main");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 1f,
                Process = Refs.Chop,
                Result = Refs.LeekChopped
            }
        };

        public override void OnRegister(Item item)
        {
            Prefab.ApplyMaterialToChild("Leek Model", "Raw Potato - Skin");
        }
    }
}
