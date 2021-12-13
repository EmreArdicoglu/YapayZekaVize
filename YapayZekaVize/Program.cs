using System;

namespace YapayZekaVize
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new MLModel1.ModelInput();
            args = new string[7];
            sampleData.Data_as_of = args[0];
            sampleData.Start_Date = args[1];
            sampleData.End_Date = args[2];
            sampleData.Sex = args[3];
            sampleData.Age_Years = args[4];
            sampleData.Total_deaths = 15827F;
                
            Console.WriteLine("Veri Tarihi Degerini girin :");
            sampleData.Data_as_of = Console.ReadLine();
            
            Console.WriteLine("Veri Baslangic degerini girin :");
            sampleData.Start_Date = Console.ReadLine();
 
            Console.WriteLine("Veri Bitis degerini girin :");
            sampleData.End_Date = Console.ReadLine();
 
            Console.WriteLine("Cinsiyet degerini girin :");
            sampleData.Sex = Console.ReadLine();
 
            Console.WriteLine("Yas degerini girin :");
            sampleData.Age_Years = Console.ReadLine();
 
            Console.WriteLine(@"Toplam Vefat :" + sampleData.Total_deaths);
            var result = MLModel1.Predict(sampleData);
            Console.WriteLine($"\n\nTahmini Covid-19 Vefat: {result.Score}\n\n");
            Console.ReadLine();

        }
    }
}
