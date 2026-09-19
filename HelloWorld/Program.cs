// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Макс";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Москва";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;

// string myName = "Иван";
// int myAge = 20;
// string myGroup = "ИСП-242";
// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}");

// Console.Write("Введите имя");
// string name = Console.ReadLine();
// Console.WriteLine($"Привет, {name}!");

// Console.Write("Введите ваш возраст");
// string input = Console.ReadLine();
// int age = int.Parse(input);
// Console.WriteLine(age + 10);

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y); 
// Console.WriteLine(x - y); 
// Console.WriteLine(x * y); 
// Console.WriteLine(x / y); 
// Console.WriteLine(x % y); 

// string fn = "Ринат";
// string ln = "Гибадуллин";
// string group = "ИСП-242";
// int bY = 2008;
// double gpa = 4.5;
// bool hasScholarship = false;
// int cY = 2026;
// int age = cY - bY;

// Console.WriteLine("Удостоверение");
// Console.WriteLine($"Имя: {fn} {ln}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний бал: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("Введите ваш любимый предмет");
// string obj = Console.ReadLine();
// Console.WriteLine($"{fn} любит {obj}");

int a = 15;
int b = 4;
Console.WriteLine($"Сумма: {a + b}");
Console.WriteLine($"Разность: {a - b}");
Console.WriteLine($"Произведение: {a * b}");
Console.WriteLine($"Частное (int): {a / b}");
Console.WriteLine($"Остаток: {a % b}");

double res = (double)a / b;
Console.WriteLine($"Частное (double): {res}");

Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Pow(2, 10));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Max(10, 25));
Console.WriteLine(Math.Min(10, 25));
Console.WriteLine(Math.Round(3.567, 2));

Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {num1 - num2}");
Console.WriteLine($"Произведение: {num1 * num2}");

if (num2 != 0)
{
    Console.WriteLine($"Частное: {num1 / num2}");
} else
{
    Console.WriteLine("Деление на ноль невозможно!");
}

