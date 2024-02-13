

using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace KitchenDutchSnacks.Mains
{
    class PlatedBiBiBiBi : CustomItemGroup<DutchSnacksItemGroupView>
    {

        public const string MOD_NAME = "Eddy";
        public override string UniqueNameID => "PlatedBitterballen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Dutch Snacks Complete");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemValue ItemValue => ItemValue.Large;
        public override Item DisposesTo => Refs.Plate;
        public override Item DirtiesTo => Refs.DirtyPlate;
        public override bool CanContainSide => true;

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
        };


        public override void OnRegister(GameDataObject gameDataObject)
        {
            var snacks = Prefab.GetChild("Snacks");
            var plate = Prefab.GetChild("Plate/Plate");

            //Visuals

            snacks.ApplyMaterialToChild("bitterbal_01_model", "Raw Potato - Skin");
            snacks.ApplyMaterialToChild("bitterbal_02_model", "Raw Potato - Skin");
            snacks.ApplyMaterialToChild("bitterbal_03_model", "Raw Potato - Skin");
            snacks.ApplyMaterialToChild("bitterbal_04_model", "Raw Potato - Skin");

            plate.ApplyMaterialToChild("Cylin", "Plate", "Plate - Ring");

            Debug.LogError($"[{MOD_NAME}] " + "Got here");


            Prefab.GetComponent<DutchSnacksItemGroupView>()?.Setup(Prefab);
        }
    }


    public class DutchSnacksItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Plate/Plate.001/Cylinder"),
                    Item = Refs.Plate,
                },
                new()
                {
                    Item = Refs.Bitterbal,
                    Objects = new List<GameObject>()
                    {
                        GameObjectUtils.GetChildObject(prefab, "Snacks/bitterbal_01_model"),
                        GameObjectUtils.GetChildObject(prefab, "Snacks/bitterbal_02_model"),
                        GameObjectUtils.GetChildObject(prefab, "Snacks/bitterbal_03_model"),
                        GameObjectUtils.GetChildObject(prefab, "Snacks/bitterbal_04_model"),
                    }
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

