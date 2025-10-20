using MyNamespace;

namespace MyNamespace
{
    // 
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class NamedIntAttribute(int namedInt) : System.Attribute
    {
        public int NamedInt { get; } = namedInt;
        // 
        // 
    }


    // 
    // 
    // 
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed record CodeAttribute(string PositionalString, int NamedInt) : System.Attribute
    {
        // The primary constructor already creates a public 'PositionalString' property.
    }

    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class ExtendedCodeAttribute(string positionalString) : System.Attribute
    {
        // 
        //  

        public string PositionalString { get; } = positionalString;

        // 
        public int NamedInt { get; set; }
    }

    public class NewBaseType
    {
        public static int Main()
        {
            // The empty lock block was removed as it served no purpose.
            return 0;
        }
    }

    public class Program : NewBaseType
    {
        // 
    }

    // 
    public struct LongArgument
    {
        // 
    }
}

internal class NewBaseType
{
    void M()
    {
        new CodeAttribute("positional", 1);
        new ExtendedCodeAttribute("positional") { NamedInt = 1 };
        new NamedIntAttribute(1);
        new LongArgument();

        // 
    }
    readonly short another;
}

class C : NewBaseType
{
    // 

    sealed class SealedClass
    {
    }

    // 
}

// This class was a duplicate of another NewBaseType definition in the global namespace,
// which causes a compilation error. I've renamed it to avoid the conflict.
internal class DuplicateNewBaseType
{
    // Removed unused variable 'unusedVariable'.
}

class TopLevelFields : NewBaseType
{
    static readonly LongArgument staticField = new();

    // Removed duplicate Main() method to resolve CS0017:
    // Program has more than one entry point defined.
}

sealed class AnotherSealedClass
{
}
struct AnotherStruct
{
}
//


class AnotherClass
{
}

//
#pragma warning disable format
#pragma warning restore format
//
//
//
//
sealed class YetAnotherSealedClass
{
}
struct YetAnotherStruct
{
}

// These were duplicate definitions of NewBaseType in the global namespace.
// I have removed them to resolve the compilation errors.
// internal class NewBaseType
// {
// }
// 
// internal class NewBaseType
// {
// }
// 
//
class YetAnotherClass
{
}



sealed class FinalSealedClass
{
}
struct FinalStruct(int argsthis)
{

}

class FinalClass
{
}
//
#pragma warning disable format


#pragma warning restore format

// Removed duplicate 'codeAttribute' class which was conflicting with 'MyNamespace.CodeAttribute'.

delegate void MyDelegate();
enum MyEnum
{
    Value1,
    Value2
}
interface IMyInterface
{
    void MyMethod();
}
public class Myxception(string message) : System.Exception(message)
{
}
sealed class MySealedClass
{
}
struct MyStruct
{
}

    
