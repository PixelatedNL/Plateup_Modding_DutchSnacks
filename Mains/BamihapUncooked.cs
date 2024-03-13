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
    internal class BamihapUncooked : CustomItem
    {
        public override string UniqueNameID => "BamihapUncooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bamihap Uncooked");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_UBamihap", MaterialConstants.MixingBowl);
            Prefab.ApplyMaterialToChild("Uncooked_Bamihap", MaterialConstants.Uncooked);
        }
    }
}
