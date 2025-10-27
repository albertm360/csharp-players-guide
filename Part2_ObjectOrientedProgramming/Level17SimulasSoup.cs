namespace Part2_ObjectOrientedProgramming;

public class Level17SimulasSoup
{
    static FoodTypes GetFood(int choice)
    {
        switch (choice)
        {
            case 1:
                return FoodTypes.Soup;
            case 2:
                return FoodTypes.Stew;
            case 3:
                return FoodTypes.Gumbo;
        }

        // It should be impossible to reach this, but it's a workaround for not 
        // having a default value to return:
        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected food type choice.");
    }

    static MainIngredients GetMainIngredient(int choice)
    {
        switch (choice)
        {
            case 1:
                return MainIngredients.Mushrooms;
            case 2:
                return MainIngredients.Chicken;
            case 3:
                return MainIngredients.Carrots;
            case 4:
                return MainIngredients.Potatoes;
        }

        // It should be impossible to reach this, but it's a workaround for not 
        // having a default value to return:
        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected main ingredient choice.");
    }

    static Seasonings GetSeasoning(int choice)
    {
        switch (choice)
        {
            case 1:
                return Seasonings.Spicy;
            case 2:
                return Seasonings.Salty;
            case 3:
                return Seasonings.Sweet;
        }

        // It should be impossible to reach this, but it's a workaround for not 
        // having a default value to return:
        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected seasoning choice.");
    }

    static int PrintEnumValues<TEnum>() where TEnum : Enum
    {
        Type enumType = typeof(TEnum);

        var enumValues = Enum.GetValues(enumType);

        Console.WriteLine($"--- {enumType.Name} Options ---");
        for (int i = 0; i < enumValues.Length; i++)
        {
            var enumValue = enumValues.GetValue(i);
            Console.WriteLine($"{i + 1} - {enumValue}");
        }

        return enumValues.Length;
    }

    static int GetValidChoice(string prompt, int totalItems)
    {
        do
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= totalItems) return choice;

            Console.WriteLine("Wrong input, enter the number of the item...");
        } while (true);
    }

    public static void Run()
    {
        (FoodTypes Type, MainIngredients Ingredient, Seasonings Seasoning) soup;
        const string SimulasSoup = "Welcome to Simula's Soups!";
        const string Choice = "What's your choice? ";
        Console.WriteLine(SimulasSoup);

        int totalFoodItems = PrintEnumValues<FoodTypes>();
        FoodTypes foodChoice = GetFood(GetValidChoice(Choice, totalFoodItems));

        int totalIngredientItems = PrintEnumValues<MainIngredients>();
        MainIngredients ingredientChoice = GetMainIngredient(GetValidChoice(Choice, totalIngredientItems));

        int totalSeasoningItems = PrintEnumValues<Seasonings>();
        Seasonings seasoningChoice = GetSeasoning(GetValidChoice(Choice, totalSeasoningItems));

        soup = (Type: foodChoice, Ingredient: ingredientChoice, Seasoning: seasoningChoice);
        Console.WriteLine($"Your choice is: ");
        Console.WriteLine(
            $"{soup.Type} with {soup.Ingredient.ToString().ToLower()} as main ingredient, and {soup.Seasoning.ToString().ToLower()} seasoning.");
    }
}