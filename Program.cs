string input = File.ReadAllText("Calories.txt");
System.Console.WriteLine(PartOne());
System.Console.WriteLine(PartTwo());

long PartOne()
{
    long highestCalories = input
        .Split("\r\n\r\n")
        .Select(elf => elf
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(0L, (acc, value) => acc + long.Parse(value)))
        .Max();

    return highestCalories;
}
long PartTwo()
{
    long highestThreeElves = input
        .Split("\r\n\r\n")
        .Select(elf => elf
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(0L, (acc, value) => acc + long.Parse(value)))
        .OrderDescending()
        .Take(3)
        .Sum();

    return highestThreeElves;
}



