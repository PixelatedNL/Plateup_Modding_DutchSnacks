

using DutchSnacks_Library.Utils;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace KitchenDutchSnacks.Mains
{
    class PlatedDutchSnacks : CustomItemGroup<PlatedSnacksItemGroupView>
    {
        public override string UniqueNameID => "PlatedDutchSnacks";
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
                Max = 3,
                Min = 3,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Bitterbal,
                    Refs.Kaassoufle,
                    //Refs.Bamihap
                }
            },
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            //Visuals
            LoggingHelper.LogError(Prefab.GetChildCount());
            Prefab.ApplyMaterialToChild("bitterbal_01_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("bitterbal_02_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("bitterbal_03_model", "Raw Potato - Skin");
            Prefab.ApplyMaterialToChild("kaassoufle_01_model", "Flour Bag");
            Prefab.ApplyMaterialToChild("kaassoufle_02_model", "Flour Bag");
            Prefab.ApplyMaterialToChild("kaassoufle_03_model", "Flour Bag");
            //Prefab.ApplyMaterialToChild("bamihap_01_model", "Paint - Deep Red");
            //Prefab.ApplyMaterialToChild("bamihap_02_model", "Paint - Deep Red");
            //Prefab.ApplyMaterialToChild("bamihap_03_model", "Paint - Deep Red");

            Prefab.ApplyMaterialToChild("complete_plate", "Plate", "Plate - Ring");

            Prefab.GetComponent<PlatedSnacksItemGroupView>()?.Setup(Prefab);
        }
    }


    public class PlatedSnacksItemGroupView : ItemGroupView
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
                    },
                    Item = Refs.Bitterbal
                },
                new()
                {
                    Objects = new List<GameObject>()
                    {
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_01_model"),
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_02_model"),
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_03_model"),
                    },
                    Item = Refs.Kaassoufle
                },
                //new()
                //{
                //    Objects = new List<GameObject>()
                //    {
                //        GameObjectUtils.GetChildObject(prefab, "bamihap_01_model"),
                //        GameObjectUtils.GetChildObject(prefab, "bamihap_02_model"),
                //        GameObjectUtils.GetChildObject(prefab, "bamihap_03_model"),
                //    },
                //    Item = Refs.Flour //todo //BAMIHAP
                //},
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Bi",
                    Item = Refs.Bitterbal
                },
                new ()
                {
                    Text = "Ka",
                    Item = Refs.Kaassoufle
                },
                //new ()
                //{
                //    Text = "Ba",
                //    Item = Refs.Flour //todo //BAMIHAP
                //},
            };
        }
    }
}

