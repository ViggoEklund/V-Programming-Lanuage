using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CSharp;
using V;
namespace V
{
    public class Compiler
    {
        bool int_01_taken = false;
        bool int_02_taken = false;
        bool int_03_taken = false;
        bool int_04_taken = false;
        bool int_05_taken = false;
        string int_01_name = "/na";
        string int_02_name = "/na";
        string int_03_name = "/na";
        string int_04_name = "/na";
        string int_05_name = "/na";
        int int_01_value = 0;
        int int_02_value = 0;
        int int_03_value = 0;
        int int_04_value = 0;
        int int_05_value = 0;
        int selected_type = 0;
        int selected_number = 0;
        string if_type = "";
        string if_which = "";
        string if_is = "0";
        string if_event = "";
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
            }
            else if (number == 02)
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
        public string RemoveLast(string text, string character)
        {
            if (text.Length < 1) return text;
            return text.Remove(text.ToString().LastIndexOf(character), character.Length);
        }
        public void compile(string code, string if_01, string if_02, string if_03, string if_04, string if_05)
        {
            var cc = new V.custom_class();
            foreach (string a in code.Split('\n'))
            {


                //Simple, commands!
                if (a.StartsWith("print " + '"'))
                {
                    string text = a.Substring(7);
                    text = RemoveLast(text, '"'.ToString());
                    if (int_01_name == text)
                    {
                        Console.WriteLine(int_01_value);
                    }
                    else if (int_02_name == text)
                    {
                        Console.WriteLine(int_02_value);
                    }
                    else if (int_03_name == text)
                    {
                        Console.WriteLine(int_03_value);
                    }
                    else if (int_04_name == text)
                    {
                        Console.WriteLine(int_04_value);
                    }
                    else if (int_05_name == text)
                    {
                        Console.WriteLine(int_05_value);
                    }
                    else
                    {
                        Console.WriteLine(text);
                    }
                }
                else
                if (a.StartsWith("select_int "))
                {
                    string text = a.Substring(11);
                    if (text == int_01_name)
                    {
                        selected_number = 01;
                        selected_type = 01;
                    } else if (text == int_02_name)
                    {
                        selected_number = 02;
                        selected_type = 01;
                    }
                    else if (text == int_03_name)
                    {
                        selected_number = 03;
                        selected_type = 01;
                    }
                    else if (text == int_04_name)
                    {
                        selected_number = 04;
                        selected_type = 01;
                    }
                    else if (text == int_05_name)
                    {
                        selected_number = 05;
                        selected_type = 01;
                    }
                    else { Console.WriteLine("Error, to find int!"); }
                }
                else
                if (a.StartsWith("add "))
                {
                    string text = a.Substring(4);
                    int val = 0;
                    Int32.TryParse(text, out val);
                    int_01_value += val;
                }
                else
                if (a.StartsWith("remove "))
                {
                    string text = a.Substring(7);
                    int val = 0;
                    Int32.TryParse(text, out val);
                    int_01_value -= val;
                }
                else if (a.StartsWith("read"))
                {
                    Console.Read();
                }
                else if (a.StartsWith("if_type int"))
                {
                    if_type = "01";
                }
                else if (a.StartsWith("if_which "))
                {
                    string text = a.Substring(9);
                    if_which = text;
                }
                else if (a.StartsWith("if_is "))
                {
                    string text = a.Substring(6);
                    if_is = text;
                }
                else if (a.StartsWith("if_event "))
                {
                    string text = a.Substring(9);
                    if_event = text;
                }
                else if (a.StartsWith("if_start"))
                {
                    if (if_type == "01")
                    {
                        if (int_01_name == if_which)
                        {
                            int val = 0;
                            Int32.TryParse(if_is, out val);
                            if (int_01_value == val)
                            {
                                new Compiler().compile(if_01, "", "", "", "", "");
                            }
                        } else
                        if (if_which == int_02_name)
                        {
                            int val = 0;
                            Int32.TryParse(if_is, out val);
                            if (int_02_value == val)
                            {
                                new Compiler().compile(if_02, "", "", "", "", "");
                            }
                        }
                        else
                        if (if_which == int_03_name)
                        {
                            int val = 0;
                            Int32.TryParse(if_is, out val);
                            if (int_03_value == val)
                            {
                                new Compiler().compile(if_03, "", "", "", "", "");
                            }
                        }
                        else
                        if (if_which == int_04_name)
                        {
                            int val = 0;
                            Int32.TryParse(if_is, out val);
                            if (int_03_value == val)
                            {
                                new Compiler().compile(if_04, "", "", "", "", "");
                            }
                        }
                        else
                        if (if_which == int_05_name)
                        {
                            int val = 0;
                            Int32.TryParse(if_is, out val);
                            if (int_04_value == val)
                            {
                                new Compiler().compile(if_05, "", "", "", "", "");
                            }
                        }
                        else { Console.WriteLine("Error, cannot define what, if_which is!"); }
                    } else { Console.WriteLine("Error, cannot define what, if_type is!"); }
                }
                else
                if(a.StartsWith(class_name_01))
                {
                     if (class_c == true)
                     {
                             new Compiler().compile(class_code_01, "", "", "", "", "");
                     }
                } else if (a.StartsWith(class_name_02))
                {
                    if (class_c == true)
                    {
                        new Compiler().compile(class_code_02, "", "", "", "", "");
                    }
                }
                else if (a.StartsWith(class_name_03))
                {
                    if (class_c == true)
                    {
                        new Compiler().compile(class_code_03, "", "", "", "", "");
                    }
                }
                else if (a.StartsWith(class_name_04))
                {
                    if (class_c == true)
                    {
                        new Compiler().compile(class_code_04, "", "", "", "", "");
                    }
                }
                else if (a.StartsWith(class_name_05))
                {
                    if (class_c == true)
                    {
                        new Compiler().compile(class_code_05, "", "", "", "", "");
                    }
                }
                //Int/String/Bool!
                else if (a.StartsWith("int " + '*'))
                {
                    string text = a.Substring(5);
                    text = RemoveLast(text, '*'.ToString());
                    if(int_01_taken == false) {
                        int_01_taken = true;
                        int_01_name = text;
                    } else if (int_02_taken == false)
                    {
                        int_02_taken = true;
                        int_02_name = text;
                    }
                    else if (int_03_taken == false)
                    {
                        int_03_taken = true;
                        int_03_name = text;
                    }
                    else if (int_04_taken == false)
                    {
                        int_04_taken = true;
                        int_04_name = text;
                    }
                    else if (int_05_taken == false)
                    {
                        int_05_taken = true;
                        int_05_name = text;
                    }
                    else
                    {
                        Console.WriteLine("V, Error no free, INT slots!");
                    }
                }
                //variables!

                //IF!
                
            }
        }
    }
}
