using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static IngredientLib.Util.VisualEffectHelper;

namespace KitchenDutchSnacks.Mains
{
    public class BitterballenPotCooked : CustomItem
    {
        public override string UniqueNameID => "Bitterballen Pot Cooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bitterballen Cooked In Pot");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 3f;
        public override int SplitCount => 1;
        public override Item SplitSubItem => Refs.CookedBitterballen;
        public override List<Item> SplitDepletedItems => new() { Refs.Pot };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("BitterballenCookedPot", "MetalLight", "MetalDark");
            Prefab.ApplyMaterialToChild("BitterballenCookedInPot", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenCookedOil", "Plastic - Light Yellow");
        }
    }
}
