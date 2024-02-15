using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace KitchenDutchSnacks.Mains
{
    public class BamihapCooked : CustomItem
    {
        public override string UniqueNameID => "CookedBitterballen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Bitterballen");
        public override bool AllowSplitMerging => false;
        public override int SplitCount => 4;
        public override float SplitSpeed => 1.5f;
        public override Item SplitSubItem => Refs.Bitterbal;
        public override bool PreventExplicitSplit => false; 

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_CBitterballen", "Metal Dark");
            Prefab.ApplyMaterialToChild("Bitterbal_01", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("Bitterbal_02", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("Bitterbal_03", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("Bitterbal_04", "Raw Potato - Skin");


            if (!Prefab.HasComponent<BamihapCookedItemView>())
            {
                var view = Prefab.AddComponent<BamihapCookedItemView>();
                view.Setup(Prefab);
            }
        }
    }

    public class BamihapCookedItemView : ObjectsSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fObjects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("Bitterbal_01"),
                prefab.GetChild("Bitterbal_02"),
                prefab.GetChild("Bitterbal_03"),
                prefab.GetChild("Bitterbal_04"),
            });
        }
    }
}