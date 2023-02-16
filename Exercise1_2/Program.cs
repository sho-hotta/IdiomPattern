// See https://aka.ms/new-console-template for more information

using Exercise1_2;

var myClass = new MyClass { X = 2, Y = 4 };
var myStruct = new MyStruct { X = 2, Y = 4 };

PrintObjects(myClass, myStruct);
Console.WriteLine($"MyClass: {myClass.X}, {myClass.Y}");
Console.WriteLine($"MyStruct: {myStruct.X}, {myStruct.Y}");

void PrintObjects(MyClass myClass, MyStruct myStruct)
{
    myClass.X *= 2;
    myClass.Y *= 2;
    myStruct.X *= 2;
    myStruct.Y *= 2;

    Console.WriteLine($"MyClass: {myClass.X}, {myClass.Y}");
    Console.WriteLine($"MyStruct: {myStruct.X}, {myStruct.Y}");
}