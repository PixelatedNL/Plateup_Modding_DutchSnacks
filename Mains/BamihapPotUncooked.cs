using Kitchen;
using KitchenData;
using KitchenLib.Colorblind;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KitchenData.ItemGroup;
using UnityEngine;
using DutchSnacks_Library.Utils;

namespace KitchenDutchSnacks.Mains
{
    class BamihapPotUncooked : CustomItemGroup<BamihapPotUncookedItemGroupView>
    {
        public override string UniqueNameID => "Bamihap Pot Uncooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bamihap Uncooked In Pot");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DisposesTo => Refs.Pot;

        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            new ItemSet()
            {
                Max = 3,
                Min = 3,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Refs.BamihapUncooked,
                    Refs.Pot,
                    Refs.OilIngredient,
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess()
            {
                Duration = 3f,
                Process = Refs.Cook,
                Result = Refs.BamihapPotCooked
            }
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("BamihapPotUncookedPot", MaterialConstants.Pot);
            Prefab.ApplyMaterialToChild("BamihapPotUncookedModel", MaterialConstants.Uncooked);
            Prefab.ApplyMaterialToChild("BamihapPotUncookedOil", MaterialConstants.Oil);

            Prefab.GetComponent<BamihapPotUncookedItemGroupView>()?.Setup(Prefab);
        }
    }
    public class BamihapPotUncookedItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "BamihapPotUncookedPot"),
                    Item = Refs.Pot
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "BamihapPotUncookedOil"),
                    Item = Refs.OilIngredient
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "BamihapPotUncookedModel"),
                    Item = Refs.BamihapUncooked
                }
            };
        }
    }
}
