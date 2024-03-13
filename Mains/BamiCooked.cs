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
    public class BamiCooked : CustomItem
    {
        public override string UniqueNameID => "BamiCooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Bami Main");
        public override bool PreventExplicitSplit => false;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Cooked Bami Model", MaterialConstants.CookedBami);
            Prefab.ApplyMaterialToChild("Mixing_Bowl_Bami", MaterialConstants.MixingBowl);
        }
    }
}