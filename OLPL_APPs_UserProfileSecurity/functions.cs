using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLPL_APPs_UserProfileSecurity
{
    class functions
    {
        public settings getSettings()
        {
            settings st1 = new settings();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            st1.EXE_Loc = System.IO.Path.GetDirectoryName(path);
            st1.EXE_Loc = st1.EXE_Loc + "\\";
            string[] SettingMain = File.ReadAllLines("settings2.dat");
            string stParentFolder = getSettingINI(SettingMain, "parentfolder");
            if (stParentFolder.Contains(';'))
            {
                st1.parentFolders = stParentFolder.Split(';');
            }
            else { st1.parentFolders[0] = stParentFolder; }
            string StraddUser = getSettingINI(SettingMain, "adduser");
            if (StraddUser.Contains(";"))
            {
                st1.addUsers = StraddUser.Split(';');
            }
            else { st1.addUsers[0] = StraddUser; }

            return st1;
        }
        public static string getSettingINI(string[] str, string strName)
        {
            foreach (string str1 in str)
            {
                if (str1.ToLower().Contains(strName))
                {
                    return str1.Split('=')[1];
                }
            }
            return "none";
        }
    }
}
