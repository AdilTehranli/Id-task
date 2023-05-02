
namespace Homework3.models;

internal class Student
{
    public int Id { get; set; }
    public static int count { get; set; }
    public Student()
    {
        count++;
        Id += count;
    }
}
