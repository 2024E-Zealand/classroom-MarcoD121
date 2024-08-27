// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");
List<Student> students = new List<Student>();
students.Add(new Student("Marco", 8, 8));
students.Add(new Student("Sebastian", 7, 20));

ClassRoom datamatiker1b = new ClassRoom()
{
    Class_Room = "3Q",
    StudentList = students,
    Semester_Start = new DateTime(2024, 8, 26)
};

Console.WriteLine(datamatiker1b);
Console.WriteLine(datamatiker1b.StudentList.First().Season());
Console.WriteLine(datamatiker1b.StudentList.Last().Season());
