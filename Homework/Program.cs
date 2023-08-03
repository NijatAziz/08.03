using Homework;

internal class Program
{
    private static void Main()
    {
        string mainText = "Bu bir custom contains methodudur";

        string searchText = "XX";
        bool contains = mainText.CustomContains(searchText);
        Console.WriteLine($"'{searchText}' cumlede ardicil olaraq varmi? {contains}");
    }
}