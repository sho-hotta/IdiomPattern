// See https://aka.ms/new-console-template for more information

using Exercise1_3;

var student = new Student { Name = "Bob", Birthday = new DateTime(2000, 1, 1), Grade = 2, ClassNumber = 2 };

Console.WriteLine(student.Name);
Console.WriteLine(student.Birthday);
Console.WriteLine(student.Grade);
Console.WriteLine(student.ClassNumber);

Person person = student;
Console.WriteLine(person.ToString());
