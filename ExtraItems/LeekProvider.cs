using System.Collections.Generic;
using KitchenAmericanBreakfast;

namespace KitchenDutchSnacks.ExtraItems
{
    class LeekProvider : CustomAppliance
    {
        public override string UniqueNameID => "LeekProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Leek Provider");
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
            GetCItemProvider(Refs.Leek.ID, 999, 999, false, false, false, false, false, true, false)
        };

        public override void OnRegister(GameDataObject gameDataObject)
        {
            //var holdTransform = Prefab.GetChild("Block/HoldPoint").transform;
            //var holdPoint = Prefab.AddComponent<HoldPointContainer>();
            //holdPoint.HoldPoint = holdTransform;

            // Visuals

            Prefab.ApplyMaterialToChild("crate_01", "Wood - Default");
            Prefab.ApplyMaterialToChild("crate_02", "Wood - Default");
            Prefab.ApplyMaterialToChild("crate_03", "Wood - Default");

            Prefab.ApplyMaterialToChild("leek01", "Flour Bag");
            Prefab.ApplyMaterialToChild("leek02", "Flour Bag");
            Prefab.ApplyMaterialToChild("leek03", "Flour Bag");
            Prefab.ApplyMaterialToChild("leek04", "Flour Bag");
            Prefab.ApplyMaterialToChild("leek05", "Flour Bag");
            Prefab.ApplyMaterialToChild("leek06", "Flour Bag");

        }
    }
}
