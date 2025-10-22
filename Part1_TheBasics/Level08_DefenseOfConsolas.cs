namespace Part1_TheBasics;

public class Level08_DefenseOfConsolas
{
    static (uint unitPosition1, uint unitPosition2) GetUnitPositions(uint targetPosition)
    {
        uint unitPosition1 = targetPosition + 1;
        uint unitPosition2 = targetPosition - 1;
        
        return (unitPosition1, unitPosition2);
    }
    
    static uint GetTargetPosition(string prompt)
    {
        const uint maxPosition = 8;
        const uint minPosition = 1;
        
        do
        {
            uint number;
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (uint.TryParse(input, out number) && number >= minPosition && number <= maxPosition)
            {
                return number;
            }
            
            Console.WriteLine("Invalid input. Please, enter a non-negative integer.");
        } while (true);
    }
    
    public static void Run()
    {
        Console.Title = "Defense of Consolas";
        const string targetRowString = "What is the target row of the magic barrier? ";
        const string targetColumnString = "What is the target column of the magic barrier? ";
        
        uint targetRowPosition = GetTargetPosition(targetRowString);
        uint targetColumnPosition = GetTargetPosition(targetColumnString);
        
        Console.WriteLine($"You have chosen row {targetRowPosition} and column {targetColumnPosition}.");
        
        (uint unitRow1, uint unitRow2) = GetUnitPositions(targetRowPosition);
        (uint unitColumn1, uint unitColumn2) = GetUnitPositions(targetColumnPosition);
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Units will be deployed on the following positions:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Unit 1: Row {targetRowPosition}, Column {unitColumn1}");
        Console.WriteLine($"Unit 2: Row {targetRowPosition}, Column {unitColumn2}");
        Console.WriteLine($"Unit 3: Row {unitRow1}, Column {targetColumnPosition}");
        Console.WriteLine($"Unit 4: Row {unitRow2}, Column {targetColumnPosition}");
        VictoryFanfare.Play();
        Console.ResetColor();
    }
}