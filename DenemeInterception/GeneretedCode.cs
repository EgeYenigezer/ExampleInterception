using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace DenemeInterception
{
    public static class GeneretedCode
    {
        [InterceptsLocation(@"C:\Users\Ege Yenigezer\Desktop\Interception\ExampleInterception\DenemeInterception\Program.cs", 8,31)]
        public static string InterceptionMethod(this Example example,string param)
        {
            return $"{param},deneme interception";
        }

    }
}
