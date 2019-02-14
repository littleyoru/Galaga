using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaga
{
    public static class Utility
    {
        public static int ReadFromFile(string path)
        {
            int score = 0; 
            try
            {
                if (!File.Exists(path))
                {
                    using(File.Create(path)) { };
                }
                else
                {
                    using(var file = new StreamReader(path))
                    {
                        string line;
                        if((line = file.ReadLine()) != null)
                        {
                            score = int.TryParse(line, out int sc) ? sc : 0;
                        }
                    }
                }
                return score;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public static void WriteToFile(string path, string text)
        {
            try
            {
                using(var newFile = new StreamWriter(path, false))
                {
                    newFile.WriteLine(text);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
