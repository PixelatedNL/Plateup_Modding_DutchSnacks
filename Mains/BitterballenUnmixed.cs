using DutchSnacks_Library.Utils;
using Kitchen;
using KitchenAmericanBreakfast.Utils;
using KitchenData;
using KitchenLib.Colorblind;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KitchenDutchSnacks.Mains
{
    internal class BitterballenUnmixed : CustomItemGroup<UnmixedBitterbalItemGroupView>
    {
        public override string UniqueNameID => "UnmixedBitterballen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Unmixed Bitterballen");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        //public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.MeatChopped,
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.MeatChopped,
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.CrackedEgg,
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.Flour,
                }
            }
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 1f,
                Process = Refs.Knead,
                Result = Refs.UncookedBitterballen
            }
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl", MaterialConstants.MixingBowl);
            Prefab.ApplyMaterialToChild("Egg_Cracked", MaterialConstants.CrackedEgg);
            Prefab.ApplyMaterialToChild("Meat_Chopped_01", MaterialConstants.MeatChopped);
            Prefab.ApplyMaterialToChild("Meat_Chopped_02", MaterialConstants.MeatChopped);
            Prefab.ApplyMaterialToChild("Flour", MaterialConstants.Flour);

            Prefab.GetComponent<UnmixedBitterbalItemGroupView>()?.Setup(Prefab);
        }
    }
    public class UnmixedBitterbalItemGroupView : ItemGroupView
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
                        GameObjectUtils.GetChildObject(prefab, "Meat_Chopped_01"), 
                        GameObjectUtils.GetChildObject(prefab, "Meat_Chopped_02")
                    },
                    Item = Refs.MeatChopped
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Egg_Cracked"),
                    Item = Refs.CrackedEgg
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Flour"),
                    Item = Refs.Flour
                }
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Me",
                    Item = Refs.MeatChopped
                },
                new ()
                {
                    Text = "Me",
                    Item = Refs.MeatChopped
                },
                new ()
                {
                    Text = "Eg",
                    Item = Refs.CrackedEgg
                },
                new ()
                {
                    Text = "Fl",
                    Item = Refs.Flour
                }
            };
        }
    }
}
