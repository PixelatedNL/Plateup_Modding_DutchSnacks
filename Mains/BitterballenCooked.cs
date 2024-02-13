using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenAmericanBreakfast.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KitchenDutchSnacks.Mains
{
    class BitterballenCooked : CustomItem
    {
        public override string UniqueNameID => "CookedBitterballen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Uncooked Bitterballen");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override Item SplitSubItem => Refs.Bitterbal;
        public override List<Item> SplitDepletedItems => new() { Refs.Bitterbal };
        public override int SplitCount => 3;
        public override float SplitSpeed => 1.5f;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            //Prefab.ApplyMaterialToChild("Bowl.001", "Metal Dark");
            //Prefab.ApplyMaterialToChild("Flour.001", "Raw Pastry");
        }
    }
}
