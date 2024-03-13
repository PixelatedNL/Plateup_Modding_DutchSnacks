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
    internal class BamihapUnmixed : CustomItemGroup<UnmixedBamihapItemGroupView>
    {
        public override string UniqueNameID => "BamihapUnmixed";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Unmixed Bamihap");
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Max = 1,
                Min = 1,
                Items = new List<Item>()
                {
                    Refs.BamiCooked,
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
                Result = Refs.BamihapUncooked
            }
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            Prefab.ApplyMaterialToChild("Mixing_Bowl_Bami", MaterialConstants.MixingBowl);
            Prefab.ApplyMaterialToChild("Unmixed Egg Cracked", MaterialConstants.CrackedEgg);
            Prefab.ApplyMaterialToChild("Cooked Bami Model", MaterialConstants.CookedBami);
            Prefab.ApplyMaterialToChild("Unmixed Flour", MaterialConstants.Flour);
            

            Prefab.GetComponent<UnmixedBamihapItemGroupView>()?.Setup(Prefab);
        }
    }
    public class UnmixedBamihapItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Cooked Bami Model"),
                    Item = Refs.BamiCooked
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Unmixed Egg Cracked"),
                    Item = Refs.CrackedEgg
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Unmixed Flour"),
                    Item = Refs.Flour
                }
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Bc",
                    Item = Refs.BamiCooked
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
