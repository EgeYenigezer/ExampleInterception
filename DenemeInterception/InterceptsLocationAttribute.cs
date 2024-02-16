using System.Runtime.CompilerServices;
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method)]
    public class InterceptsLocationAttribute(string filePath, int line,int character) : Attribute
    {

    }
}