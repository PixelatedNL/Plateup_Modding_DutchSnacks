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
    class KaassoufleDish : CustomDish
    {
        public override string UniqueNameID => "Kaassoufle Dish";
        public override DishType Type => DishType.Main;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override int Difficulty => 3;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Refs.DutchSnacksDish
        };

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Refs.Kaassoufle,
                MenuItem = Refs.PlatedDutchSnacks
            },
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Refs.Cheese,
            Refs.Flour,
            Refs.Egg,
            Refs.Water,
            Refs.Pot,
            Refs.Oil
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Refs.Cook,
            Refs.Knead,
            Refs.Chop
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Add oil to a pot. Combine two chopped cheese with a cracked egg, flour, dough and mix together. Cook in the pot with oil and portion out of the pot when done. Portion and add to plate up to 3 times." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Kaassoufle", "Adds Kaassoufle as an option for Dutch Snacks", "Make sure to blow") )
        };
    }
}
