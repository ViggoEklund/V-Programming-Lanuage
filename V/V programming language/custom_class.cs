using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    public class custom_class
    {
        bool class_c = false;
        string class_name_01 = "/na";
        string class_code_01 = "/na";
        string class_name_02 = "/na";
        string class_code_02 = "/na";
        string class_name_03 = "/na";
        string class_code_03 = "/na";
        string class_name_04 = "/na";
        string class_code_04 = "/na";
        string class_name_05 = "/na";
        string class_code_05 = "/na";
        public void set_class_c(bool chose)
        {
            class_c = chose;
        }
        public void set_strings(string name_01, string code_01, string name_02, string code_02, string name_03, string code_03, string name_04, string code_04, string name_05, string code_05)
        {
            class_name_01 = name_01;
            class_code_01 = code_01;
            class_name_02 = name_02;
            class_code_02 = code_02;
            class_name_03 = name_03;
            class_code_03 = code_03;
            class_name_04 = name_04;
            class_code_04 = code_04;
            class_name_05 = name_05;
            class_code_05 = code_05;
        }
        public bool return_if_use()
        {
            return class_c;
        }
        public string return_name(int number)
        {
            if (number == 01)
            {
                return class_name_01;
            } else if (number == 02)
            {
                return class_name_02;
            }
            else if (number == 03)
            {
                return class_name_03;
            }
            else if (number == 04)
            {
                return class_name_04;
            }
            else if (number == 05)
            {
                return class_name_05;
            }
            else { return "Error, cannot define what number"; }
        }
        public string return_code(int number)
        {
            if (number == 01)
            {
                return class_code_01;
            }
            else if (number == 02)
            {
                return class_code_02;
            }
            else if (number == 03)
            {
                return class_code_03;
            }
            else if (number == 04)
            {
                return class_code_04;
            }
            else if (number == 05)
            {
                return class_code_05;
            }
            else { return "Error, cannot define what number"; }
        }
    }
}
