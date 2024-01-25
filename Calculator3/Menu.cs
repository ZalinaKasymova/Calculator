using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    internal class Menu
    {
        public void Init()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Консольное приложение для работы с очень большими целыми числами");
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");
                Console.Write("Введите номер операции: ");
                string choice = Console.ReadLine();

                var firstInput = ValidNumber(choice);
                var secondInput = ValidNumber(choice);
                MyBigInteger bigInteger1 = new MyBigInteger(firstInput);
                MyBigInteger bigInteger2 = new MyBigInteger(secondInput);
                MyBigInteger result = null;
                switch (choice)
                {
                    case "1":
                        result = MyBigInteger.Add(bigInteger1, bigInteger2);
                        break;
                    case "2":
                        result = MyBigInteger.SubtractOperation(bigInteger1, bigInteger2);
                        break;
                    case "3":
                        result = MyBigInteger.Multiplication(bigInteger1, bigInteger2);
                        break;
                    case "4":
                        result = MyBigInteger.Devide(bigInteger1, bigInteger2);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
                Console.WriteLine("Результат: " + result);
                break;
            }
        }

        private string ValidNumber(string operation)
        {
            Console.WriteLine("Введите число");
            var input = Console.ReadLine() ?? string.Empty;
            var res = MyBigInteger.TryParse(input);
            if (!res)
            {
                Console.WriteLine("Некорректный ввод, Повторите еще раз");
                return ValidNumber(operation);
            }

            if(operation == "4" && input == "0")
            {
                Console.WriteLine("Деление на 0 невозможно");
                return ValidNumber(operation);
            }
            return input;
        }

    }
}
