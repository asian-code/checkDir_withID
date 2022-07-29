using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ID check thingy: ");
        using (var reader = new StreamReader(@"C:\Users\eric.nguyen\Documents\test.csv"))
        {
            reader.ReadLine(); //ignore first line
            List<string> listA = new List<string>();
            //List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
                //var values = line.Split(';');

                //listA.Add(values[0]);
                //listB.Add(values[1]);
            }
        }
    }
}