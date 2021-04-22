using BusinessLogic.IModels;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class StructureAnalyse: IStructureAnalyse
	{

            public  int CheckStucture(string code)
            {
                int start = IsFitVar10(code);
            if (start == -1)
            {
                Console.WriteLine("ERROR");
                return -1;       
            }
                while (code[start] == ' ')
                    start++;
                switch (code[start])
                {
                    case ';':
                        code = code.Insert(start, "count++");
                        break;
                    case '{':
                        code = code.Insert(start + 1, "count++;");
                        break;
                    default:
                        code = code.Insert(start, "{count++;");
                        start += 9;
                        start = code.IndexOf(';', start);
                        if (start == -1)
                            return 0;
                        code = code.Insert(++start, "}");
                        break;
                }
                var provider = new CSharpCodeProvider();
                var parameters = new CompilerParameters { GenerateInMemory = true };
                parameters.ReferencedAssemblies.Add("System.dll");
                try
                {
                    var results = provider.CompileAssemblyFromSource(parameters, $@"
                    using System;
 
                    public static class Checker 
                    {{
                        public static int F()
                        {{
                            int count=0;
                            {code}
                            return count;
                        }}
                    }}");
                    var method = results.CompiledAssembly.GetType("Checker").GetMethod("F");
                    var func = (Func<int>)Delegate.CreateDelegate(typeof(Func<int>), null, method);
                    return func();
                }
                catch (FileNotFoundException)
                {                 
                    throw new ArgumentException("Input should be valid C# expression", nameof(code));              
                }
            }

            private static int IsFitVar10(string code)
            {
                int startStruct = code.IndexOf("foreach");
                if (startStruct != -1)
                {
                    startStruct += 7;
                    while (startStruct < code.Length && code[startStruct] == ' ')
                        startStruct++;
                    if ((startStruct < code.Length) && (code[startStruct] != ')'))
                    {
                        startStruct = code.IndexOf(')', startStruct);
                        if (startStruct != -1)
                        {
                            startStruct++;
                        }
                    }
                    else
                        startStruct = -1;
                }
                return startStruct;
            }
		public int CheckWhileDoStucture(string code)
		{
			int start = IsFitVar101(code);
			if (start == -1)
				return 0;
			while (code[start] == ' ')
				start++;
			switch (code[start])
			{
				case ';':
					code = code.Insert(start, "count++");
					break;
				case '{':
					code = code.Insert(start + 1, "count++;");
					break;
				default:
					code = code.Insert(start, "{count++;");
					start += 9;
					start = code.IndexOf(';', start);
					if (start == -1)
						return 0;
					code = code.Insert(++start, "}");
					break;
			}
			var provider = new CSharpCodeProvider();
			var parameters = new CompilerParameters { GenerateInMemory = true };
			parameters.ReferencedAssemblies.Add("System.dll");
			try
			{
				var results = provider.CompileAssemblyFromSource(parameters, $@"
                    using System;
 
                    public static class Checker 
                    {{
                        public static int F()
                        {{
                            int count=0;
                            {code}
                            return count;
                        }}
                    }}");
				var method = results.CompiledAssembly.GetType("Checker").GetMethod("F");
				var func = (Func<int>)Delegate.CreateDelegate(typeof(Func<int>), null, method);
				return func();
			}
			catch (FileNotFoundException)
			{
				throw new ArgumentException("Input should be valid C# expression", nameof(code));
			}
		}

		private static int IsFitVar101(string code)
		{
			//do { }
			//while (true);
			int startStruct = code.IndexOf("do");
			if (startStruct != -1)
			{
				startStruct += 2;
				while (startStruct < code.Length && code[startStruct] == ' ')
					startStruct++;
				if ((startStruct < code.Length) && (code[startStruct] != '}'))
				{
					startStruct = code.IndexOf('}', startStruct);
					if (startStruct != -1)
					{
						startStruct++;
					}
				}
				else
					startStruct = -1;
			}
			return startStruct;
		}
	}
    
}
