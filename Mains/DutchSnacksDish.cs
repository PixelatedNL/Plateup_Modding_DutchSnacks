using KitchenLib.Preferences;
using System.Collections.Generic;

namespace KitchenDutchSnacks.Mains
{
    class DutchSnacksDish : CustomDish
    {
        public override string UniqueNameID => "Dutch Snacks Dish";
        public override DishType Type => DishType.Base;
        public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("Dutch Snacks Display Icon");
        public override GameObject IconPrefab => DisplayPrefab;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.LargeDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsSpecificFranchiseTier => false;
        public override bool DestroyAfterModUninstall => false;
        public override bool IsUnlockable => true;
        public override bool IsAvailableAsLobbyOption => true;

        public override List<string> StartingNameSet => new List<string>
        {
            "Dutch Oven",
            //"Waffle This Way",
            //"Flippin' Tasty",
            //"Flapjack Fantasy",
            //"Batter Up",
            //"Scrambled Shenanigans",
            //"Flapjack Factory",
            //"Eggcellent Eats",
            //"The Pancake Pitstop",
            //"Waffle Wagon",
            //"Pancake Party",
            //"Waffle Workshop",
            //"Pancake Paradise",
            //"Pancake Palace"
        };

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Refs.PlatedDutchSnacks,
                Phase = MenuPhase.Main,
                Weight = 1
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Refs.Meat,
            Refs.Egg,
            Refs.Flour,
            Refs.Plate,
            Refs.Pot,
            Refs.Oil,
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Refs.Cook,
            Refs.Chop,
            Refs.Knead
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Add oil to a pot. Combine two chopped meats with a cracked egg, flour and mix together. Cook in the pot with oil and Portion out of the pot. Portion up to 4 times."}
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Dutch Snacks", "Adds bitterballen as a main", "") )
        };

        public override void OnRegister(GameDataObject gameDataObject)
        {
            // Visuals 

            DisplayPrefab.ApplyMaterialToChild("display_bamihap", "Paint - Deep Red");
            DisplayPrefab.ApplyMaterialToChild("display_bitterbal", "Raw Potato - Skin");
            DisplayPrefab.ApplyMaterialToChild("display_frikandel", "Mushroom Cooked");
            DisplayPrefab.ApplyMaterialToChild("display_kaassoufle", "Flour Bag");
            DisplayPrefab.ApplyMaterialToChild("display_plate", "Plate", "Plate - Ring");
        }
    }
}
