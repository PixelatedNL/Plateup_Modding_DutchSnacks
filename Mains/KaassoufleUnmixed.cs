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
    internal class KaassoufleUnmixed : CustomItemGroup<KaassoufleUnmixedItemGroupView>
    {
        public override string UniqueNameID => "UnmixedKaassoufle";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Unmixed Kaassoufle");
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.ChoppedCheese,
                }
            },
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.ChoppedCheese,
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
                    Refs.Dough,
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
                Duration = .5f,
                Process = Refs.Knead,
                Result = Refs.KaassoufleUncooked
            }
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl", "Metal Dark");
            Prefab.ApplyMaterialToChild("Egg_Cracked", "Egg - Yolk", "Egg - White", "ALMixingBowl");
            Prefab.ApplyMaterialToChild("Cheese_Chopped_01", "Cheese - Default");
            Prefab.ApplyMaterialToChild("Cheese_Chopped_02", "Cheese - Default");
            Prefab.ApplyMaterialToChild("Flour", "Flour");
            Prefab.ApplyMaterialToChild("Flour", "Raw Pastry");

            Prefab.GetComponent<KaassoufleUnmixedItemGroupView>()?.Setup(Prefab);
        }
    }
    public class KaassoufleUnmixedItemGroupView : ItemGroupView
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
                        GameObjectUtils.GetChildObject(prefab, "Cheese_Chopped_01"), 
                        GameObjectUtils.GetChildObject(prefab, "Cheese_Chopped_02")
                    },
                    Item = Refs.ChoppedCheese
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
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Dough"),
                    Item = Refs.Dough
                }
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Ch",
                    Item = Refs.ChoppedCheese
                },
                new ()
                {
                    Text = "Ch",
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
                },
                new ()
                {
                    Text = "Do",
                    Item = Refs.Dough
                }
            };
        }
    }
}
