/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой, создайте структуру с именем Price, содержащую следующие
поля: название товара, название магазина, в котором продается товар, тоимость товара в
гривнах. Написать логику, которая будет выполнять следующие действия: 1) ввод с клавиатуры
данных в массив, состоящий из двух элементов типа Price (записи должны быть упорядочены в
алфавитном порядке по названиям магазинов); 2) вывод на экран информации о товарах,
продающихся в магазине, название которого введено с клавиатуры (если такого магазина нет,
вывести исключение).
*/
Price[] products = new Price[2];

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Введите название магазина:");
    products[i].StoreName = Console.ReadLine();

    Console.WriteLine("Введите название товара:");
    products[i].ProductName = Console.ReadLine();

    Console.WriteLine("Введите цену товара, грн.:");
    products[i].ProductPrice = int.Parse(Console.ReadLine());
}

products.OrderBy(x => x.StoreName);

Console.WriteLine("Введите название магазина:");
string storeNameInput = Console.ReadLine();

try
{
    bool isExist = true;
    foreach (var item in products)
    {
        if (item.StoreName.Contains(storeNameInput))
        {
            Console.WriteLine($"Магазин: {item.StoreName}");
            Console.WriteLine($"Название товара: {item.ProductName}");
            Console.WriteLine($"Цена товара: {item.ProductPrice} грн.");
            isExist = true;
            break;
        }
        else isExist = false;
    }
    if (!isExist) throw new Exception();
}
catch (Exception)
{
    Console.WriteLine("Магазин не найден");
}

Console.ReadKey();
struct Price
{
    public string ProductName { get; set; }
    public string StoreName { get; set; }
    public int ProductPrice { get; set; }
}