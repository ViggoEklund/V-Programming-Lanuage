using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool use_class_bool = false;
            bool compile = true;
            int value;
            var VPL = new V.Compiler();
            var VPL_2 = new V.custom_class();
            string Code = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\program.v");
            string use_class = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class.s");
            string compile_code = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\compile_code.c");
            string if_01 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_01.v");
            string if_02 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_02.v");
            string if_03 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_03.v");
            string if_04 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_04.v");
            string if_05 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_05.v");
            string name_01 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01.n");
            string name_02 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02.n");
            string name_03 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03.n");
            string name_04 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04.n");
            string name_05 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05.n");
            string event_01 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01_event.n");
            string event_02 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02_event.n");
            string event_03 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03_event.n");
            string event_04 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04_event.n");
            string event_05 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05_event.n");
            if (compile == true)
            {
                CSharpCodeProvider provider = new CSharpCodeProvider();
                ICodeCompiler compiler = provider.CreateCompiler();

                CompilerParameters parameters = new CompilerParameters();
                parameters.ReferencedAssemblies.Add("V programming language.dll");
                parameters.GenerateExecutable = true;
                parameters.GenerateInMemory = false;
                parameters.OutputAssembly = "Program.exe";
                parameters.TreatWarningsAsErrors = false;



                CompilerResults result = compiler.CompileAssemblyFromSource(parameters, compile_code);

                if (result.Errors.Count != 0)
                {
                    foreach (CompilerError er in result.Errors)
                    {
                        Console.WriteLine(er.ToString());
                    }
                } else
                {
                    Process.Start("Program.exe");
                }
                compile = false;

            }
            else if (compile == false)
            {


                if (use_class == "true")
                {
                    VPL.set_class_c(true);
                    VPL.set_strings(name_01, event_01, name_02, event_02, name_03, event_03, name_04, event_04, name_05, event_05);
                    use_class_bool = true;
                }
                else
                {
                    VPL.set_class_c(false);
                    use_class_bool = false;
                }
                VPL.compile(Code, if_01, if_02, if_03, if_04, if_05);
            }
        }
        
    }
}
