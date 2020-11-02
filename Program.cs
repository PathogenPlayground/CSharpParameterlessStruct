using System;

Console.WriteLine("=====================================================================");
Console.WriteLine(default(MyStruct));
Console.WriteLine(new MyStruct("Hello, world!"));
Console.WriteLine(new MyStruct());
Console.WriteLine(Activator.CreateInstance<MyStruct>());
Console.WriteLine(Activator.CreateInstance(typeof(MyStruct), Array.Empty<object>(), Array.Empty<object>()));
Console.WriteLine("=====================================================================");

public struct MyStruct
{
    public string Message;

    public MyStruct() // Note: Intellisense will show an error on this line because it uses the Roslyn bundled with Visual Studio
        => Message = "Initialized from parameterless constructor.";

    public MyStruct(string message)
        => Message = message;

    public override string ToString()
        => Message ?? "Defaulted struct.";
}
