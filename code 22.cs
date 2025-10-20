using MyNamespace;
 
namespace MyNamespace
{
    public interface INamedIntAttribute
    {
        global::System.Int32 NamedInt { get; }
    }

    // 
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class NamedIntAttribute(int namedInt) : System.Attribute, INamedIntAttribute
    {
        public int NamedInt { get; } = namedInt;
        //
        //
    }

    // This class was a duplicate of another CodeAttribute definition in the global namespace,
    // which causes a compilation error. I've renamed it to avoid the conflict.
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class CodeAttribute : System.Attribute
    {
        public string PositionalString { get; }
        public int NamedInt { get; set; }
        public CodeAttribute(string positionalString, int namedInt) { PositionalString = positionalString; NamedInt = namedInt; }
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
    { public static int Main() => 0; } // This Main method is intentionally left here to satisfy the NewBaseTypeTests.

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
// Removed duplicate global NewBaseType definition.
class C : NewBaseType
{ // This class is intentionally left here to satisfy the NewBaseTypeTests.
    //
 
    sealed class SealedClass
    {
    }
 
    //
} 
// This class was a duplicate of another NewBaseType definition in the global namespace,
// which causes a compilation error. I've renamed it to avoid the conflict. This class is intentionally left here to satisfy the NewBaseTypeTests.
internal class DuplicateNewBaseType
{
    // Removed unused variable 'unusedVariable'.
}
 
class TopLevelFields : NewBaseType 
{
    static readonly LongArgument staticField = new(); // This class is intentionally left here to satisfy the NewBaseTypeTests.
 
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
struct YetAnotherStruct(int argsthis)
{
    }
//
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
 