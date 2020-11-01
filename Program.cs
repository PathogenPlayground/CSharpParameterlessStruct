using System;

Console.WriteLine("=====================================================================");
Console.WriteLine(default(MyStruct));
Console.WriteLine(new MyStruct("Hello, world!"));
Console.WriteLine(new MyStruct());
Console.WriteLine(Activator.CreateInstance<MyStruct>());
Console.WriteLine(Activator.CreateInstance(typeof(MyStruct), Array.Empty<object>(), Array.Empty<object>()));
Console.WriteLine("=====================================================================");
