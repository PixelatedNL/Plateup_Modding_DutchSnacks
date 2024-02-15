﻿

using DutchSnacks_Library.Utils;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace KitchenDutchSnacks.Mains
{
    class PlatedBiBiBiBi : CustomItemGroup<PlatedBiBiBiBiItemGroupView>
    {
        public override string UniqueNameID => "PlatedBiBiBiBi";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Snacks Complete");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemValue ItemValue => ItemValue.Large;
        public override Item DisposesTo => Refs.Plate;
        public override Item DirtiesTo => Refs.DirtyPlate;
        public override bool CanContainSide => true;
        public override int MaxOrderSharers => 2;
        public override ToolAttachPoint HoldPose => ToolAttachPoint.HandFlat;

        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            // Plate
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Refs.Plate
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Bitterbal,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Bitterbal,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Bitterbal,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Bitterbal,
                }
            },
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            //Visuals
            LoggingHelper.LogError(Prefab.GetChildCount().ToString());
            Prefab.ApplyMaterialToChild("bitterbal_01_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("bitterbal_02_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("bitterbal_03_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("bitterbal_04_model", "Raw Potato - Skin");

            Prefab.ApplyMaterialToChild("complete_plate", "Plate", "Plate - Ring");

            Prefab.GetComponent<PlatedBiBiBiBiItemGroupView>()?.Setup(Prefab);
        }
    }


    public class PlatedBiBiBiBiItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "complete_plate"),
                    Item = Refs.Plate,
                },
                new()
                {
                    Objects = new List<GameObject>()
                    {
                        GameObjectUtils.GetChildObject(prefab, "bitterbal_01_model"),
                        GameObjectUtils.GetChildObject(prefab, "bitterbal_02_model"),
                        GameObjectUtils.GetChildObject(prefab, "bitterbal_03_model"),
                        GameObjectUtils.GetChildObject(prefab, "bitterbal_04_model"),
                    },
                    Item = Refs.Bitterbal
                },
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Bi",
                    Item = Refs.Bitterbal
                },
            };
        }
    }
}

