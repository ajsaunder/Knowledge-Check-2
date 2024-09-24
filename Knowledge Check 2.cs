using Knowledge_Chec_2;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Inventory : Merchandise
{  public override string ToString()
    {

        return $"Records Artist: {Artist}, Title: {Title:C}, ReleaseYear {ReleaseYear}, Price {Price}, Album {Album};";


    }}

public class Program: Merchandise
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");

        var Records = int.Parse(Console.ReadLine());

        var recordList = new List<Inventory>();

        for (int i = 0; i < Records; i++)

        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Inventory = new Inventory();

            Console.WriteLine("Enter the record name: ");
            Inventory.Title = Console.ReadLine();

            Console.WriteLine("Enter the artist: ");
            Inventory.Artist = (Console.ReadLine());

            Console.WriteLine("Enter the release year of the record ");
            Inventory.ReleaseYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the Album ");
            Inventory.Album = (Console.ReadLine());

            Console.WriteLine("Enter the price of the record ");
            Inventory.Price = int.Parse(Console.ReadLine());
            recordList.Add(Inventory);
        }
        Console.WriteLine("\nRecords added:");
        foreach (var record in recordList)
        { Console.WriteLine(record.ToString()); }
    }
   
}

// Print out the list of records using Console.WriteLine()
