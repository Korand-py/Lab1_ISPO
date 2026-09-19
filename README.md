# Лабораторная работа №1. Платформа .NET
ФИО: Окишев Максим Сегеевич
и Гибадуллин Ринат Рамильевич
Группа: ИСП-242

Дата: 19.09.2026

Краткое описание:
Изучили базовые команды терминала, настроили редактор vs code. Изучили типы данных, переменные, операторы if / else и вывод в консоль.

Структура проекта:

Hello World/

├── img                     <- скриншоты лабораторной работы

├── .gitignore              <- файлы, которые git игнорирует

├── HelloWorld.csproj       <- конфигурация проекта

└── Program.cs              <- главный файл программы

Пример кода:

```csharp
Console.WriteLine("Добро пожаловать в анкету!");
Console.WriteLine("Введите имя: ");
String name = Console.ReadLine();
Console.WriteLine("Введите фамилию: ");
String surname = Console.ReadLine();
Console.WriteLine("Введите группу: ");
String group = Console.ReadLine();
Console.WriteLine("Введите год рождения: ");
int birthYear = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ваш средний бал (4.5): ");
double gpa = double.Parse(Console.ReadLine());

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;
string status;
if (isExcellent == true) status = "Отличник";
else status = "Хорошист";

Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний бал: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");
Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();
```
