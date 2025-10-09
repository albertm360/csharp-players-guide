namespace Part1_TheBasics;

public class Level07_TheTriangleFarmer
{
    static float Area(float width, float height)
    {
        return (width * height) / 2;
    }

    static float GetPositiveFloat(string prompt)
    {
        float number;

        do
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (float.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        } while (true);
    }
    
    public static void Run()
    {
        string widthPrompt = "What's the width of the triangle?";
        string heightPrompt = "What's the height of the triangle?";
        
        float width = GetPositiveFloat(prompt: widthPrompt);
        float height = GetPositiveFloat(prompt: heightPrompt);

        float area = Area(width: width, height: height);
        Console.WriteLine($"The area of the triangle is {area}");
    }
}