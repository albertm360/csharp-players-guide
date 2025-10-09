namespace Part1_TheBasics;

public class Level06_VariableShopReturns
{
    public static void Run()
    {
        // Integer types:
        int integer = -1;
        uint uintInt = 1U;
        short shortInt = -1;
        ushort ushortInt = 1;
        long longInt = -1L;
        ulong ulongInt = 1UL;
        byte byteInt = 1;
        sbyte sbyteInt = -1;
        
        // Text types:
        char character = 'A';
        string stringText = "A string";
        
        // Floating point types:
        float floatNumber = 1.2f;
        double doubleNumber = 1.2;
        decimal decimalNumber = 1.2m;
        
        // Logical type:
        bool boolean = true;
        
        // Updates
        integer = 4;
        uintInt = 4;
        shortInt = 4;
        ushortInt = 4;
        longInt = 4;
        ulongInt = 4;
        byteInt = 4;
        sbyteInt = 4;
        character = 'B';
        stringText = "Another string";
        floatNumber = 1.4f;
        doubleNumber = 2.0;
        decimalNumber = 3.1m;
        boolean = false;
        
        Console.WriteLine("--- Integer Types ---");
        Console.WriteLine($"{nameof(integer)}:  {integer}");
        Console.WriteLine($"{nameof(uintInt)}:  {uintInt}");
        Console.WriteLine($"{nameof(shortInt)}:  {shortInt}");
        Console.WriteLine($"{nameof(ushortInt)}:  {ushortInt}");
        Console.WriteLine($"{nameof(longInt)}:  {longInt}");
        Console.WriteLine($"{nameof(ulongInt)}:  {ulongInt}");
        Console.WriteLine($"{nameof(byteInt)}:  {byteInt}");
        Console.WriteLine($"{nameof(sbyteInt)}:  {sbyteInt}");
        Console.WriteLine("\n--- Text Types ---");
        Console.WriteLine($"{nameof(character)}:  {character}");
        Console.WriteLine($"{nameof(stringText)}:  {stringText}");
        Console.WriteLine("\n--- Floating Point Types ---");
        Console.WriteLine($"{nameof(floatNumber)}:  {floatNumber}");
        Console.WriteLine($"{nameof(doubleNumber)}:  {doubleNumber}");
        Console.WriteLine($"{nameof(decimalNumber)}:  {decimalNumber}");
        Console.WriteLine("\n--- Logical Type ---");
        Console.WriteLine($"{nameof(boolean)}:  {boolean}");
    }
}