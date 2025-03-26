namespace Task_3
{
    internal class Program
    {

        #region Create a generic method Swap<T> that swaps two variables of any type

        //static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static void Main()
        //{
        //    int x = 5, y = 10;
        //    Console.WriteLine($"Before swap: x = {x}, y = {y}");
        //    Swap(ref x, ref y);
        //    Console.WriteLine($"After swap: x = {x}, y = {y}");

        //    string str1 = "Karim", str2 = "Mahmoud";
        //    Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        //    Swap(ref str1, ref str2);
        //    Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
        //}
        #endregion

        #region Create a Dictionary<string, int> to store student names and their grades

        //static void DisplayGrade(Dictionary<string, int> students, string name)
        //{
        //    if (students.TryGetValue(name, out int grade))
        //    {
        //        Console.WriteLine($"{name}'s Grade: {grade}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Student {name} not found");
        //    }
        //}

        //static void Main()
        //{
        //    Dictionary<string, int> StudentGrades = new Dictionary<string, int>()
        //{
        //    {"Karim", 90},
        //    {"Ahmed", 85},
        //    {"Mohammed", 78},
        //    {"Nemsa", 92},
        //    {"Yosr", 88}
        //};

        //    DisplayGrade(StudentGrades, "Mohammed");
        //    DisplayGrade(StudentGrades, "Yosr");
        //    DisplayGrade(StudentGrades, "X");
        //}
        #endregion

        #region Implement a Queue<string> to simulate a customer service line

        //static void Main()
        //{
        //    Queue<string> customerQueue = new Queue<string>();
        //    customerQueue.Enqueue("Ali");
        //    customerQueue.Enqueue("Youssef");
        //    customerQueue.Enqueue("Mostafa");

        //    Console.WriteLine("\nProcessing Customers:");
        //    while (customerQueue.Count > 0)
        //    {
        //        Console.WriteLine($"Serving: {customerQueue.Dequeue()}");
        //    }
        //}
        #endregion

    }
}
