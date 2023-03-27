using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите название автомобиля: ");

        string car = Console.ReadLine().ToUpper();
        /* Читаю значение, которое ввёл пользователь. Метод ToUpper(); приводит значение,
        которое ввёл пользователь, к верхнему регистру. Это нужно для того, чтобы не возникало недоразумений.
        Например: У меня в словаре записан автомобиль RX-9. Пользователь вводит rx-9, и, как вы понимаете, на деле то
        такая машина есть, но в словаре она не найдётся, ведь у меня записано RX-9.*/

        var dict = new Dictionary <string, string>
        {
            ["RX-9"] = "Mazda",
            ["CX-5"] = "Mazda",
            ["RX-7"] = "Mazda",
            ["ЖИГУЛИ"] = "ВАЗ",
            ["OCTAVIA"] = "Škoda Auto",
            ["RAPID"] = "Škoda Auto",
            ["GALLARDO"] = "Lamborghini",
            ["MURCIELAGO"] = "Lamborghini",
            ["VEYRON"] = "Bugatti",
            ["PANAMERA"] = "Porsche"
        };
        /* Здесь создал новый словарь, и заполнил его своими данными. Где, значение в [] является ключом,
        а значение после знака =, данными, которые он хранит. Тип данных, который ты используешь, указывается после
        Dictionary в <>. Это необязательно должен быть тип данных string, как у меня.*/

        if (dict.ContainsKey(car))
        // Метод ContainsKey(TKey)	Проверяет наличие в словаре указанного ключа.
        {
            Console.WriteLine($"Марка этого автомобиля: {dict[car]}");

            dict.Remove(car);
            // Метод Remove(TKey)	Удаляет элемент с указанным ключом.

            foreach (var key in dict.Keys) Console.WriteLine("\n" + dict[key]);
            // Вывод оставшихся элементов. В моём случае, это марки автомобилей.

            dict.Clear();
            // Метод Clear()	Удаляет из словаря все ключи и значения.

            foreach (var key in dict.Keys) Console.WriteLine(dict[key]);
            // Здесь будет пустой вывод, т.к. значний в словаре не осталось. Надеюсь, комментариев хватит.
        }
        else
            Console.WriteLine("Такого автомобиля в словаре нет.");
    }
}