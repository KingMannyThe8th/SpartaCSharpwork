using lab_04_dll; 

namespace lab_05_useDll
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("reading from another library");

             var item = new EmmanuelLibrary();
            item.EmmanuelsData = "some data here";
            System.Console.WriteLine("item.EmmanuelsData");
            System.Console.WriteLine(item.EmmanuelsData);
            System.Console.WriteLine(item.EmmanuelsFixedData);


        }
    }
}
