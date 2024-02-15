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
    public class KaassouflePotCooked : CustomItem
    {
        public override string UniqueNameID => "Kaassoufle Pot Cooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Kaassoufle Cooked In Pot");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 3f;
        public override int SplitCount => 1;
        public override Item SplitSubItem => Refs.KaassoufleCooked;
        public override List<Item> SplitDepletedItems => new() { Refs.Pot };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("KaassouflePotCookedPot", "MetalDark", "Metal");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedOil", "Plastic - Light Yellow");
        }
    }
}
