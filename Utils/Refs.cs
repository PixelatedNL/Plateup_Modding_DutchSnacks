using KitchenDutchSnacks.Mains;

namespace KitchenDutchSnacks
{
    internal class Refs
    {
        #region Vanilla References
        // Items
        public static Item Plate => Find<Item>(ItemReferences.Plate);
        public static Item DirtyPlate => Find<Item>(ItemReferences.PlateDirty);
        public static Item Wok => Find<Item>(ItemReferences.Wok);
        public static Item BurnedWok => Find<Item>(ItemReferences.WokBurned);
        public static Item Flour => Find<Item>(ItemReferences.Flour);
        public static Item Egg => Find<Item>(ItemReferences.Egg);
        public static Item Pot => Find<Item>(ItemReferences.Pot);
        public static Item PotWithOil => Find<Item>(ItemReferences.PotWithOil);
        public static Item Water => Find<Item>(ItemReferences.Water);
        public static Item CrackedEgg => Find<Item>(ItemReferences.EggCracked);
        public static Item Sugar => Find<Item>(ItemReferences.Sugar);
        public static Item Burnt => Find<Item>(ItemReferences.BurnedFood);
        public static Item Potato => Find<Item>(ItemReferences.Potato);
        public static Item ChoppedPotato => Find<Item>(ItemReferences.PotatoChopped);
        public static Item Tomato => Find<Item>(ItemReferences.Tomato);
        public static Item ChoppedTomato => Find<Item>(ItemReferences.TomatoChopped);
        public static Item Lettuce => Find<Item>(ItemReferences.Lettuce);
        public static Item ChoppedLettuce => Find<Item>(ItemReferences.LettuceChopped);
        public static Item Cheese => Find<Item>(ItemReferences.Cheese);
        public static Item ChoppedCheese => Find<Item>(ItemReferences.CheeseGrated);
        public static Item Mushroom => Find<Item>(ItemReferences.Mushroom);
        public static Item ChoppedMushroom => Find<Item>(ItemReferences.MushroomChopped);
        public static Item Onion => Find<Item>(ItemReferences.Onion);
        public static Item ChoppedOnion => Find<Item>(ItemReferences.OnionChopped);
        public static ItemGroup Mayo => Find<ItemGroup>(ItemReferences.Mayonnaise);
        public static Item OilIngredient => Find<Item>(ItemReferences.OilIngredient);
        public static Item CookedPieCrust => Find<Item>(ItemReferences.PieCrustCooked);
        public static Item Meat => Find<Item>(ItemReferences.Meat);
        public static Item Oil => Find<Item>(ItemReferences.Oil);
        public static Item MeatChopped => Find<Item>(ItemReferences.MeatChopped);
        public static Item Leek => Find<Item, Leek>();
        public static Item Carrot => Find<Item>(ItemReferences.Carrot);
        //public static Item Noodles => Find<Item>(ItemReferences.Noodles);
        public static Item Dough => Find<Item>(ItemReferences.Dough);

        // Processes
        public static Process Cook => Find<Process>(ProcessReferences.Cook);
        public static Process Chop => Find<Process>(ProcessReferences.Chop);
        public static Process Knead => Find<Process>(ProcessReferences.Knead);
        public static Process Oven => Find<Process>(ProcessReferences.RequireOven);

        // Appliances
        public static Appliance IceCreamProvider => Find<Appliance>(ApplianceReferences.SourceIceCream);
        #endregion

        #region IngredientLib References
        public static Item Pork => (Item)GetCustomGameDataObject(IngredientLib.References.GetIngredient("pork"))?.GameDataObject; //Find<Item>(IngredientLib.References.GetIngredient("pork"));
        public static Item Bacon => Find<Item>(IngredientLib.References.GetIngredient("bacon"));
        public static Item Blueberries => Find<Item>(IngredientLib.References.GetIngredient("blueberries"));
        public static Item Oats => Find<Item>(IngredientLib.References.GetIngredient("oats"));
        public static Item Cinnamon => Find<Item>(IngredientLib.References.GetIngredient("cinnamon"));
        public static Item Syrup => Find<Item>(IngredientLib.References.GetSplitIngredient("syrup"));
        public static Item SyrupBottle => Find<Item>(IngredientLib.References.GetIngredient("syrup"));
        public static Item EggNoodle => Find<Item>(IngredientLib.References.GetIngredient("egg dough"));
        public static Item UnmixedEggDough => Find<Item>(IngredientLib.References.GetIngredient("unmixed egg dough"));
        public static Item Butter => Find<Item>(IngredientLib.References.GetIngredient("butter"));
        public static Item ButterSlice => Find<Item>(IngredientLib.References.GetSplitIngredient("butter"));
        public static Item CookedDrumstick => Find<Item>(IngredientLib.References.GetIngredient("cooked drumstick"));
        public static Item Drumstick => Find<Item>(IngredientLib.References.GetIngredient("drumstick"));
        public static Item Milk => Find<Item>(IngredientLib.References.GetIngredient("milk"));
        public static Item SplitMilk => Find<Item>(IngredientLib.References.GetSplitIngredient("milk"));
        public static Item Spinach => Find<Item>(IngredientLib.References.GetIngredient("spinach"));
        public static Item ChoppedSpinach => Find<Item>(IngredientLib.References.GetIngredient("chopped spinach"));
        #endregion

        #region ApplianceLib References
        public static Item Cup => Find<Item>(ApplianceLibGDOs.Refs.Cup.ID);

        public static Appliance CupProvider => Find<Appliance>(ApplianceLibGDOs.Refs.CupProvider.ID);
        #endregion

        #region Modded References
        // Items

        //public static Item Pancake => Find<Item, Pancake>();

        public static Dish DutchSnacksDish => Find<Dish, DutchSnacksDish>();

        // Bitterballen
        public static Item UnmixedBitterballen = Find<Item, BitterballenUnmixed>();
        public static Item UncookedBitterballen = Find<Item, BitterballenUncooked>();
        public static Item BitterballenPotUncooked = Find<Item, BitterballenPotUncooked>();
        public static Item BitterballenPotCooked = Find<Item, BitterballenPotCooked>();
        public static Item CookedBitterballen = Find<Item, BitterballenCooked>();
        public static Item Bitterbal = Find<Item, BitterballenSingle>();

        // Kaassoufle
        public static Item KaassoufleUnmixed = Find<Item, KaassoufleUnmixed>();
        public static Item KaassoufleUncooked = Find<Item, KaassoufleUncooked>();
        public static Item KaassouflePotUncooked = Find<Item, KaassouflePotUncooked>();
        public static Item KaassouflePotCooked = Find<Item, KaassouflePotCooked>();
        public static Item KaassoufleCooked = Find<Item, KaassoufleCooked>();
        public static Item Kaassoufle = Find<Item, KaassoufleSingle>();


        // All Plated Variations
        public static ItemGroup PlatedDutchSnacks => Find<ItemGroup, PlatedDutchSnacks>();


        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }

        internal static T Find<T, C>() where T : GameDataObject where C : CustomGameDataObject
        {
            return GDOUtils.GetCastedGDO<T, C>();
        }

        internal static T Find<T>(string modName, string name) where T : GameDataObject
        {
            return GDOUtils.GetCastedGDO<T>(modName, name);
        }

        private static Appliance.ApplianceProcesses FindApplianceProcess<C>() where C : CustomSubProcess
        {
            ((CustomApplianceProccess)CustomSubProcess.GetSubProcess<C>()).Convert(out var process);
            return process;
        }
        #endregion
    }
}
