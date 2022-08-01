using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string[] targetDir = Directory.GetFiles(@"C:\Users\eric.nguyen\Documents");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(String.Format("[{0}] Files Found", targetDir.Length));
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Eric is the best IT guy!\n--- Starting scan ------------------------------");
        using (var reader = new StreamReader(@"C:\Users\eric.nguyen\Documents\Programming\test.csv"))
        {
            bool seen = false;
            string dir = "";
            int c=0;//# of IDs
            reader.ReadLine(); //ignore first line

            while (!reader.EndOfStream)// read ID file
            {
                c++;
                var id = reader.ReadLine();// stores ID
                for (int i = 0; i < targetDir.Length; i++)
                {//loop the files in folder
                    seen = false;
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
                                break;
                            }
                   
                            
                        }
                    }
                    
                    
                }
                if (!seen)
                {
                    Console.Write(id);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" " + seen.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
            Console.WriteLine(String.Format("--- {0} IDs checked ------------------------------",c));


        }
    }
}