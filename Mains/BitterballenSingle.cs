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
using DutchSnacks_Library.Utils;

namespace KitchenDutchSnacks.Mains
{
    class BitterballenSingle : CustomItem
    {
        public override string UniqueNameID => "SingleSnackBitterbal";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Single Snack Bitterbal");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override ItemValue ItemValue => ItemValue.ExtraLarge;

        public override void OnRegister(Item item)
        {
            Prefab.ApplyMaterialToChild("SingelBitterbal_model", MaterialConstants.Bitterbal);
        }
    }
}
