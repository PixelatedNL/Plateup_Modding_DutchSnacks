using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenDutchSnacks.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using IngredientLib.Ingredient.Items;

namespace KitchenDutchSnacks.Mains
{
    class LeekChopped : CustomItem
    {
        public override string UniqueNameID => "LeekChoppedCustomItem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Leek Chopped Main");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.Small;


        public override void OnRegister(Item item)
        {
            Prefab.ApplyMaterialToChild("Leek Chopped Model", "Lime Inner", "Bamboo Raw", "Lime Juice");
        }
    }
}
