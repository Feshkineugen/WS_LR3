using System;


struct Student
{
    public string Name;
    public string Group;
    public int[] Performance; 

    // Метод для вычисления среднего балла
    public double GetAverageGrade()
    {
        double sum = 0;
        foreach (int grade in Performance)
        {
            sum += grade;
        }
        return sum / Performance.Length;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[7]
        {
new Student { Name = "Иванов И.И.", Group = "Группа 1", Performance = new int[] {4, 5, 3, 4, 5} },
new Student { Name = "Пашкин А.П.", Group = "Группа 2", Performance = new int[] {3, 4, 4, 5, 4} },
new Student { Name = "Сидоров С.С.", Group = "Группа 3", Performance = new int[] {5, 5, 5, 4, 5} },
new Student { Name = "Козлов К.К.", Group = "Группа 1", Performance = new int[] {3, 3, 4, 4, 3} },
new Student { Name = "Митькин Н.Н.", Group = "Группа 2", Performance = new int[] {4, 3, 4, 5, 5} },
new Student { Name = "Алексеев А.М.", Group = "Группа 3", Performance = new int[] {5, 4, 5, 5, 4} },
new Student { Name = "Григорьев Г.Г.", Group = "Группа 1", Performance = new int[] {5, 5, 4, 5, 4} }
        };

        Array.Sort(students, (x, y) => x.GetAverageGrade().CompareTo(y.GetAverageGrade()));

        Console.WriteLine("Студенты, упорядоченные по возрастанию среднего балла:");
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}, Средний балл: {student.GetAverageGrade()}");
        }
    }
}