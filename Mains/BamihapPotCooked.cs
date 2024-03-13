using DutchSnacks_Library.Utils;
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
    public class BamihapPotCooked : CustomItem
    {
        public override string UniqueNameID => "BamihapPotCooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bamihap Cooked In Pot");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 3f;
        public override int SplitCount => 6;
        public override Item SplitSubItem => Refs.Bamihap;
        public override List<Item> SplitDepletedItems => new() { Refs.PotWithOil };
        public override Item DisposesTo => Refs.Pot;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("BamihapPotCookedPot", MaterialConstants.Pot);
            Prefab.ApplyMaterialToChild("BamihapPotCookedOil", MaterialConstants.Oil);

            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_01", MaterialConstants.Bamihap);
            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_02", MaterialConstants.Bamihap);
            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_03", MaterialConstants.Bamihap);
            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_04", MaterialConstants.Bamihap);
            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_05", MaterialConstants.Bamihap);
            Prefab.ApplyMaterialToChild("BamihapPotCookedModel_06", MaterialConstants.Bamihap);

            if (!Prefab.HasComponent<BamihapPotCookedItemView>())
            {
                var view = Prefab.AddComponent<BamihapPotCookedItemView>();
                view.Setup(Prefab);
            }
        }
    }
    public class BamihapPotCookedItemView : ObjectsSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fObjects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("BamihapPotCookedModel_01"),
                prefab.GetChild("BamihapPotCookedModel_02"),
                prefab.GetChild("BamihapPotCookedModel_03"),
                prefab.GetChild("BamihapPotCookedModel_04"),
                prefab.GetChild("BamihapPotCookedModel_05"),
                prefab.GetChild("BamihapPotCookedModel_06"),
            });
        }
    }
}