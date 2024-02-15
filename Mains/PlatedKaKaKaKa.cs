

using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace KitchenDutchSnacks.Mains
{
    class PlatedKaKaKaKa : CustomItemGroup<PlatedKaKaKaKaItemGroupView>
    {
        public override string UniqueNameID => "PlatedKaKaKaKa";
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
                    Refs.Kaassoufle,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Kaassoufle,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Kaassoufle,
                }
            },

            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory = false,
                Items = new List<Item>()
                {
                    Refs.Kaassoufle,
                }
            },
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            //Visuals

            Prefab.ApplyMaterialToChild("kaassoufle_01_model", "Flour Bag");
            Prefab.ApplyMaterialToChild("kaassoufle_02_model", "Flour Bag");
            Prefab.ApplyMaterialToChild("kaassoufle_03_model", "Flour Bag");
            Prefab.ApplyMaterialToChild("kaassoufle_04_model", "Flour Bag");

            Prefab.ApplyMaterialToChild("complete_plate", "Plate", "Plate - Ring");

            Prefab.GetComponent<PlatedKaKaKaKaItemGroupView>()?.Setup(Prefab);
        }
    }


    public class PlatedKaKaKaKaItemGroupView : ItemGroupView
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
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_01_model"),
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_02_model"),
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_03_model"),
                        GameObjectUtils.GetChildObject(prefab, "kaassoufle_04_model"),
                    },
                    Item = Refs.Kaassoufle
                },
            };
            ComponentLabels = new()
            {
                new ()
                {
                    Text = "Ka",
                    Item = Refs.Kaassoufle
                },
            };
        }
    }
}

