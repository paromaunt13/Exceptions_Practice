/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой, создайте структуру с именем Worker (работник), содержащую
следующие поля: фамилия и инициалы работника, название занимаемой должности, год
поступления на работу. Написать логику, которая будет выполнять следующие действия: 1) ввод с
клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть
упорядочены по алфавиту); 2) сли значение года введено не в соответствующем формате выдает
исключение; 3) вывод на экран фамилии работника, стаж работы которого превышает введенное
значение.
*/

Worker[] workers = new Worker[5];

for (int i = 0; i < workers.Length; i++)
{
    Console.WriteLine($"Введите данные о {i + 1} работнике:");
    Console.Write("Имя: ");
    workers[i].firstName = Console.ReadLine();

    Console.Write("Фамилия: ");
    workers[i].lastName = Console.ReadLine();

    Console.Write("Должность: ");
    workers[i].position = Console.ReadLine();

    YearInput:
    Console.Write("Год поступления на работу: ");  
        try
        {                      
            workers[i].year = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {        
            Console.WriteLine("Неверный формат введенных данных!");
            goto YearInput;
        }
    workers[i].exp = 2023 - workers[i].year;
}

workers.OrderBy(x => x.lastName);

Console.Write("Введите необходимый стаж работы: ");
int requireExp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Работники со стажем {requireExp}:");
int workerkWithRequireExp = 0;

for (int i = 0; i < workers.Length; i++)
{
    if (workers[i].exp > requireExp)
    {
        Console.WriteLine(workers[i].firstName + " " + workers[i].lastName);
        workerkWithRequireExp++;
    }
}

if (workerkWithRequireExp == 0)
    Console.WriteLine($"Работников со стажем {requireExp} не обнаружено");

public struct Worker
{
    public string firstName;
    public string lastName;
    public string position;
    public int year;
    public int exp;
}