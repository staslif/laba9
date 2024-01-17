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
            LastName = "Владимир",
            FirstName = "Владимирович",
            MiddleName = "Путин",
            Address = "ул. Пушкина, 137",
            Phone = "+72286661337",
            CreditCardNumber = "1234567812345678",
            BankAccountNumber = "1234567890123456"
        };

        customers[1] = new Customer()
        {
            LastName = "Бебриков",
            FirstName = "Бебрик",
            MiddleName = "Бебрикович",
            Address = "ул. Пушкина, 137",
            Phone = "+72286661337",
            CreditCardNumber = "8765432187654321",
            BankAccountNumber = "9876543210987654"
        };

        customers[2] = new Customer()
        {
            LastName = "Пузренков",
            FirstName = "Александр",
            MiddleName = "Николаевич",
            Address = "ул. Пушкина, 137",
            Phone = "+72286661337",
            CreditCardNumber = "1111222233334444",
            BankAccountNumber = "4444555566667777"
        };

        // Заданный номер кредитной карты
        string targetCreditCardNumber = "1111222233334444";

        // Выводим список покупателей, номер кредитной карты которых совпадает с заданным
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
