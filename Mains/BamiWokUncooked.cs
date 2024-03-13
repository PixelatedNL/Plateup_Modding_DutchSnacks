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
    class BamiWokUncooked : CustomItemGroup<BamiHapUncookedItemGroupView>
    {
        public override string UniqueNameID => "BamiWokUncooked";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Wok Uncooked Bami");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DisposesTo => Refs.Wok;

        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Noodles,
                }
            },
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Noodles,
                }
            },
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Wok,
                }
            },
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.CarrotChopped,
                }
            },
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.LeekChopped,
                }
            },
        };
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess()
            {
                Duration = 1f,
                Process = Refs.Cook,
                Result = Refs.BamiWokCooked
            }
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Wok", MaterialConstants.Wok);
            Prefab.ApplyMaterialToChild("Carrot Chopped", MaterialConstants.Carrot);
            Prefab.ApplyMaterialToChild("Leek Chopped", MaterialConstants.LeekChopped);
            Prefab.ApplyMaterialToChild("Noodle Uncooked 01", MaterialConstants.NoodlesRaw);
            Prefab.ApplyMaterialToChild("Noodle Uncooked 02", MaterialConstants.NoodlesRaw);

            Prefab.GetComponent<BamiHapUncookedItemGroupView>()?.Setup(Prefab);
        }
    }
    public class BamiHapUncookedItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    Objects = new List<GameObject> {
                        GameObjectUtils.GetChildObject(prefab, "Noodle Uncooked 01"),
                        GameObjectUtils.GetChildObject(prefab, "Noodle Uncooked 02")
                    },
                    Item = Refs.Noodles
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Leek Chopped"),
                    Item = Refs.LeekChopped
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Carrot Chopped"),
                    Item = Refs.CarrotChopped
                }
            };
        }
    }
}
