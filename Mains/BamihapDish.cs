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
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Refs.DutchSnacksDish
        };
        //public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        //{
        //    new Dish.MenuItem
        //    {
        //        Item = Refs.,
        //        Phase = MenuPhase.Main,
        //        Weight = 1
        //    }
        //};
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Refs.Leek,
            Refs.Carrot,
            Refs.Water
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Refs.Cook
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Add water and oats to a pot. Cook to make oatmeal. Portion and serve" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Oatmeal", "Adds oatmeal as a main", null) )
        };
    }
}
