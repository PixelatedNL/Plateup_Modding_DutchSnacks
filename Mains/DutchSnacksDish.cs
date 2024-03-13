using DutchSnacks_Library.Utils;
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
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsSpecificFranchiseTier => false;
        public override bool DestroyAfterModUninstall => false;
        public override bool IsUnlockable => true;
        public override bool IsAvailableAsLobbyOption => true;
        public override int Difficulty => 2;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;

        public override List<string> StartingNameSet => new List<string>
        {
            "Dutch Oven",
            "The Frying Dutchman",
            "Fry Before You Die",
            "The weekend starts with Fryday"
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

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Refs.Bitterbal,
                MenuItem = Refs.PlatedDutchSnacks
            },
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
            { Locale.English, "Add oil to a pot. Combine two chopped meats with a cracked egg, flour and mix together. Cook in the pot with oil and portion out of the pot to plate. 6 Portions."}
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Dutch Snacks", "Adds bitterballen as a main", "Not as bitter as they sound") )
        };

        public override void OnRegister(GameDataObject gameDataObject)
        {
            // Visuals 

            DisplayPrefab.ApplyMaterialToChild("display_bamihap", MaterialConstants.Bamihap);
            DisplayPrefab.ApplyMaterialToChild("display_bitterbal", MaterialConstants.Bitterbal);
            DisplayPrefab.ApplyMaterialToChild("display_kaassoufle", MaterialConstants.Kaassoufle);
            DisplayPrefab.ApplyMaterialToChild("display_plate", MaterialConstants.Plate);
        }
    }
}
