using System;
// Создаем класс "Customer" с указанными полями
class Customer
{
    public string LastName { get; set; } // Фамилия
    public string FirstName { get; set; } // Имя
    public string MiddleName { get; set; } // Отчество
    public string Address { get; set; } // Адрес
    public string Phone { get; set; } // Телефон
    public string CreditCardNumber { get; set; } // Номер кредитной карты
    public string BankAccountNumber { get; set; } // Номер банковского счета
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив объектов "Customer"
        Customer[] customers = new Customer[3];

        // Заполняем массив данными
        customers[0] = new Customer()
        {
            LastName = "биба",
            FirstName = "бобович",
            MiddleName = "бобкинов",
            Address = "ул. бородина, 23",
            Phone = "+77654321337",
            CreditCardNumber = "12132576854655678",
            BankAccountNumber = "1165768976456756"
        };

        customers[1] = new Customer()
        {
            LastName = "доктор",
            FirstName = "кто",
            MiddleName = "?",
            Address = "ул. Пушкина, 137",
            Phone = "+79876543210",
            CreditCardNumber = "1324576898798091",
            BankAccountNumber = "0789675436576587"
        };

        customers[2] = new Customer()
        {
            LastName = "ласковый",
            FirstName = "нежный",
            MiddleName = "зверь",
            Address = "ул. меджиксити, 13",
            Phone = "+73546576896",
            CreditCardNumber = "1123211233211232",
            BankAccountNumber = "1661161616611661"
        };
        string targetCreditCardNumber = "1324576898798091";
        Console.WriteLine("Список покупателей с заданным номером кредитной карты:");
        foreach (Customer customer in customers)
        {
            if (customer.CreditCardNumber == targetCreditCardNumber)
            {
                Console.WriteLine($"ФИО: {customer.LastName} {customer.FirstName} {customer.MiddleName}");
                Console.WriteLine($"Адрес: {customer.Address}");
                Console.WriteLine($"Телефон: {customer.Phone}");
                Console.WriteLine($"Номер банковского счета: {customer.BankAccountNumber}");
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
