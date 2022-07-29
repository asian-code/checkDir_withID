using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eric is the best IT guy! ");
        string[] targetDir = Directory.GetFiles(@"C:\Users\eric.nguyen\Documents");

        using (var reader = new StreamReader(@"C:\Users\eric.nguyen\Documents\test.csv"))
        {
            bool seen = false;
            string dir = "";
            reader.ReadLine(); //ignore first line

            while (!reader.EndOfStream)// read ID file
            {
                var id = reader.ReadLine();// stores ID
                for (int i = 0; i < targetDir.Length; i++)
                {//loop the folder
                    using (StreamReader sr = new StreamReader(targetDir[i]))// check current file
                    {
                        string contents = sr.ReadToEnd();
                        if (contents.Contains(id))
                        {
                            seen = true;
                            dir = targetDir[i];
                            if (seen)
                            {
                                Console.Write(id);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" " + seen.ToString() + " - " + dir);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write(id);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" " + seen.ToString());
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                    }
                    
                    seen = false;
                }
            }
            
        }
    }
}