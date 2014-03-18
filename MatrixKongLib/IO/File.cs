using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace Rock.System.IO
{
    public class File
    {
        public async static Task<string> ReadFile(string fileName)
        {
            string strbuilder;
            using (var reader = new StreamReader(Environment.CurrentDirectory + fileName))
            {
                strbuilder = await reader.ReadToEndAsync();
            }
            return strbuilder;
        }

        public async static Task<IList<string>> ReadFileToArray(string fileName)
        {
            IList<string> strbuilder = new List<string>();
            using (var reader = new StreamReader(Environment.CurrentDirectory + fileName))
            {
                while (reader.Peek() > -1)
                {
                    strbuilder.Add(await reader.ReadLineAsync());
                }
            }
            return strbuilder;
        }
    }
}
