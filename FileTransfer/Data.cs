using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    public class Data
    {
        public List<string> GetFileNameArray()
        {
            var array = new List<string>();

            array.Add("test.txt");
            
            return array;
        }
    }
}
