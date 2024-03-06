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
        public override float SplitSpeed => 1f;
        public override int SplitCount => 6;
        public override Item SplitSubItem => Refs.Bitterbal;
        public override List<Item> SplitDepletedItems => new() { Refs.PotWithOil };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("BitterballenPotCookedPot", "MetalDark", "Metal");
            Prefab.ApplyMaterialToChild("BitterballenPotCookedOil", "Plastic - Light Yellow");

            Prefab.ApplyMaterialToChild("BitterballenInPotModel_01", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenInPotModel_02", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenInPotModel_03", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenInPotModel_04", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenInPotModel_05", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("BitterballenInPotModel_06", "Raw Potato - Skin");

            if (!Prefab.HasComponent<BitterballenPotCookedItemView>())
            {
                var view = Prefab.AddComponent<BitterballenPotCookedItemView>();
                view.Setup(Prefab);
            }
        }
    }
    public class BitterballenPotCookedItemView : ObjectsSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fObjects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("BitterballenInPotModel_01"),
                prefab.GetChild("BitterballenInPotModel_02"),
                prefab.GetChild("BitterballenInPotModel_03"),
                prefab.GetChild("BitterballenInPotModel_04"),
                prefab.GetChild("BitterballenInPotModel_05"),
                prefab.GetChild("BitterballenInPotModel_06"),
            });
        }
    }
}