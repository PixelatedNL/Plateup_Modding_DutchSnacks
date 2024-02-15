using System.Collections.Generic;
using KitchenAmericanBreakfast;

namespace KitchenDutchSnacks.ExtraItems
{
    class LeekProvider : CustomAppliance
    {
        public override string UniqueNameID => "LeekProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("LeekProvider");
        public override PriceTier PriceTier => PriceTier.Medium;
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateApplianceInfo("Leek", "Provides Leek", new(), new()) )
        };

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>()
        {
            new CItemHolder(),
            GetCItemProvider(Refs.Leek.ID, 1, 1, false, false, true, false, false, true, false)
        };

        public override void OnRegister(GameDataObject gameDataObject)
        {
            //var holdTransform = Prefab.GetChild("Block/HoldPoint").transform;
            //var holdPoint = Prefab.AddComponent<HoldPointContainer>();
            //holdPoint.HoldPoint = holdTransform;

            // Visuals
           
            //Prefab.ApplyMaterialToChild("Counter")
            //Prefab.ApplyMaterialToChild("Counter Doors", paintedWood);
            //Prefab.ApplyMaterialToChild("Counter Surface", defaultWood);
            //Prefab.ApplyMaterialToChild("Counter Top", defaultWood);
            //Prefab.ApplyMaterialToChild("Handles", "Knob");
        }
    }
}
