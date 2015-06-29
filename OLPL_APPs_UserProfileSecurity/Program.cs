using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OLPL_APPs_UserProfileSecurity
{
    class Program
    {
        static void Main(string[] args)
        {
            functions fn1 = new functions();
            settings st1 = fn1.getSettings();
            foreach(string strPF in st1.parentFolders)
            {
                DirectoryInfo df1 = new DirectoryInfo(strPF);
                DirectoryInfo[] subDirs = df1.GetDirectories();
                foreach(DirectoryInfo df2 in subDirs)
                {
                    Console.WriteLine(df2.Name);
                }
            }
            Thread.Sleep(10000);
        }
    }
}
