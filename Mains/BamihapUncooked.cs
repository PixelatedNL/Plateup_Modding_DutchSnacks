using Kitchen;
using KitchenAmericanBreakfast.Utils;
using KitchenData;
using KitchenLib.Colorblind;
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
    internal class BamihapUncooked : CustomItem
    {
        public override string UniqueNameID => "UncookedBitterballen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Uncooked Bitterballen");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        //public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_Bitterballen", "Metal Dark");
            Prefab.ApplyMaterialToChild("Uncooked_Bitterbal", "Egg - White");

            Prefab.GetComponent<BamihapUncookedItemGroupView>()?.Setup(Prefab);
        }
    }
    public class BamihapUncookedItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "UncBi",
                    Item = Refs.UncookedBitterballen
                }
            };
        }
    }
}
