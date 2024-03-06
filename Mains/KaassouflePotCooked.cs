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
        public override float SplitSpeed => 1f;
        public override int SplitCount => 6;
        public override Item SplitSubItem => Refs.Kaassoufle;
        public override List<Item> SplitDepletedItems => new() { Refs.PotWithOil };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("KaassouflePotCookedPot", "MetalDark", "Metal");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedOil", "Plastic - Light Yellow");

            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_01", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_02", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_03", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_04", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_05", "Flour Bag");
            Prefab.ApplyMaterialToChild("KaassouflePotCookedModel_06", "Flour Bag");

            if (!Prefab.HasComponent<KaassouflePotCookedItemView>())
            {
                var view = Prefab.AddComponent<KaassouflePotCookedItemView>();
                view.Setup(Prefab);
            }
        }
    }
    public class KaassouflePotCookedItemView : ObjectsSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fObjects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("KaassouflePotCookedModel_01"),
                prefab.GetChild("KaassouflePotCookedModel_02"),
                prefab.GetChild("KaassouflePotCookedModel_03"),
                prefab.GetChild("KaassouflePotCookedModel_04"),
                prefab.GetChild("KaassouflePotCookedModel_05"),
                prefab.GetChild("KaassouflePotCookedModel_06"),
            });
        }
    }
}
