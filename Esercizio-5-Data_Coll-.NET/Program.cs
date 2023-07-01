using Esercizio_5_Data_Coll_.NET;

internal class Program
{
    private static void Main(string[] args)
    {
        TrainRoute route = new TrainRoute();

        
        route.AddStation("AG");
        route.AddStation("PA");
        route.AddStation("NA");
        route.AddStation("RM");
        route.AddStation("BO");
        route.AddStation("MI");

       
        route.DisplayRoute();

        Console.WriteLine();

        route.RemoveStation("BO");

       
        route.DisplayRoute();


    }
}