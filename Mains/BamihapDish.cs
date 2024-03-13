using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenDutchSnacks.Mains
{
    class BamihapDish : CustomDish
    {
        public override string UniqueNameID => "Bamihap Dish";
        public override DishType Type => DishType.Main;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.LargeDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override int Difficulty => 4;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Refs.DutchSnacksDish
        };

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Refs.Bamihap,
                MenuItem = Refs.PlatedDutchSnacks
            },
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Refs.Leek,
            Refs.Carrot,
            Refs.Noodles,
            Refs.Water,
            Refs.Wok,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Refs.Cook
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Recipe 01" }
            //{ Locale.English, "Recipe 02" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Bamihap", "Adds bamihap as an option for Dutch Snacks", "Asian food dutch style") )
        };
    }
}
