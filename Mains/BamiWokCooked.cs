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
    public class BamiWokCooked : CustomItem
    {
        public override string UniqueNameID => "BamiWokCooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Wok Cooked Bami");
        public override bool AllowSplitMerging => false;
        public override float SplitSpeed => 3f;
        public override int SplitCount => 1;
        public override Item SplitSubItem => Refs.BamiCooked;
        public override List<Item> SplitDepletedItems => new() { Refs.Wok };
        public override Item DisposesTo => Refs.Wok;
        public override bool PreventExplicitSplit => false;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Wok", MaterialConstants.Wok);
            Prefab.ApplyMaterialToChild("Carrot Chopped", MaterialConstants.Carrot);
            Prefab.ApplyMaterialToChild("Leek Chopped", MaterialConstants.LeekChopped);
            Prefab.ApplyMaterialToChild("Noodles Cooked", MaterialConstants.NoodlesCooked);

        }
    }
}