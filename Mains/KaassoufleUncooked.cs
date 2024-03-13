using DutchSnacks_Library.Utils;
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
    internal class KaassoufleUncooked : CustomItem
    {
        public override string UniqueNameID => "KaassoufleUncooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Kaassoufle Uncooked");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        //public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_UKaassoufle", MaterialConstants.MixingBowl);
            Prefab.ApplyMaterialToChild("Kaassoufle_Uncooked", MaterialConstants.Uncooked);

            Prefab.GetComponent<KaassoufleUncookedItemGroupView>()?.Setup(Prefab);
        }
    }
    public class KaassoufleUncookedItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "UncKa",
                    Item = Refs.KaassoufleUncooked
                }
            };
        }
    }
}
