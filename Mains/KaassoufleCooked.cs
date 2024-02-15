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
    public class KaassoufleCooked : CustomItem
    {
        public override string UniqueNameID => "CookedKaassoufle";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Kaassoufle Cooked");
        public override bool AllowSplitMerging => false;
        public override int SplitCount => 4;
        public override float SplitSpeed => 1.5f;
        public override Item SplitSubItem => Refs.Kaassoufle;
        public override bool PreventExplicitSplit => false; 

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_Kaassoufle", "Metal Dark");
            Prefab.ApplyMaterialToChild("Kaassoufle_01", "Flour Bag");
            Prefab.ApplyMaterialToChild("Kaassoufle_02", "Flour Bag");
            Prefab.ApplyMaterialToChild("Kaassoufle_03", "Flour Bag");
            Prefab.ApplyMaterialToChild("Kaassoufle_04", "Flour Bag");


            if (!Prefab.HasComponent<KaassoufleCookedItemView>())
            {
                var view = Prefab.AddComponent<KaassoufleCookedItemView>();
                view.Setup(Prefab);
            }
        }
    }

    public class KaassoufleCookedItemView : ObjectsSplittableView
    {
        internal void Setup(GameObject prefab)
        {
            var fObjects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            fObjects.SetValue(this, new List<GameObject>()
            {
                prefab.GetChild("Kaassoufle_01"),
                prefab.GetChild("Kaassoufle_02"),
                prefab.GetChild("Kaassoufle_03"),
                prefab.GetChild("Kaassoufle_04"),
            });
        }
    }
}