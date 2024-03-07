using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<String,int>primeMinisters=new Dictionary<String,int>();
        primeMinisters.Add("Atal Bihari Vajpayee",1998);
        primeMinisters.Add( "Narendra Modi",2014);
        primeMinisters.Add("Manmohan Singh",2004);
        int yearToFind = 2004;
        foreach (var item in primeMinisters)
        {
            if(item.Value == yearToFind)
            {
                Console.WriteLine($"Prime minister of {yearToFind}:{item.Key}");
                break;
            }
        }

        primeMinisters.Add("Narendra  Modi", DateTime.Now.Year);

        var sortedPrimeMinister = primeMinisters.OrderBy(pm => pm.Value);
        Dictionary<String, int> sortedDictionary = sortedPrimeMinister.ToDictionary(pm => pm.Key, pm => pm.Value);


        Console.WriteLine("\nSorted prime minister");
        foreach (var item in primeMinisters)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");   
        }







    }
}