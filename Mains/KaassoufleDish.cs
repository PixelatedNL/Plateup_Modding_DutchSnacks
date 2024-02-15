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
        //public override List<Unlock> HardcodedRequirements => new()
        //{
        //    Refs.DutchSnacksDish
        //};
        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Refs.PlatedKaKaKaKa,
                Phase = MenuPhase.Main,
                Weight = 1
            }
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
            { Locale.English, "Add oil to a pot. Combine two chopped cheese with a cracked egg, flour, dough and mix together. Cook in the pot with oil and portion out of the pot when done. Portion and add to plate up to 4 times." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Kaassoufle", "Adds Kaassoufle as a main", null) )
        };
    }
}
