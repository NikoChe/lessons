using System;
namespace coffestation
{
    class Methods
    {
        public static int GetSummChoice(int x, int y) => x * y;
        public static int GetOrderCoffe()
        {
        int orderCoffe;
        iniatiliseChoice:
            System.Console.WriteLine("Какой кофе ты для себя выбрал? Введи цифрой от 1 до 5.");
            //string inputChoiceCoffe = Console.ReadLine();
            //int choiceCoffe = Convert.ToInt32(inputChoiceCoffe);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var choiceCoffe))
                {
                    Console.WriteLine("Ну куда ты буквы жамкаешь? Кофе выбирается цифрами от 1 до 5.");
                }
                // else if (choiceCoffe == 0)
                // {
                //     System.Console.WriteLine("Что бы сформировать заказ, нужно указть число больше чем 0 и меньше чем 6. Например 5.");
                //     //goto inputQuantityDigit;
                // }
                else
                {
                    switch (choiceCoffe)
                    {
                        case 1:
                            System.Console.WriteLine("Ваш выбор Эспресо за 50 руб.");
                            return orderCoffe = 50;

                        case 2:
                            System.Console.WriteLine("Ваш выбор Американо за 100 руб.");
                            return orderCoffe = 100;

                        case 3:
                            System.Console.WriteLine("Ваш выбор Латте/Капучино маленький за 150 руб.");
                            return orderCoffe = 150;

                        case 4:
                            System.Console.WriteLine("Ваш выбор Латте/Капучино средний за 200 руб.");
                            return orderCoffe = 200;

                        case 5:
                            System.Console.WriteLine("Ваш выбор Латте/Капучино большой за 250 руб.");
                            return orderCoffe = 250;

                        default:
                            System.Console.WriteLine("Глупенький, не надо жмакать все кнопки подряд. Что бы выбрать напиток нужно нажимать кнопки от 1 до 5");
                            goto iniatiliseChoice;
                    }
                    //return orderCoffe;
                }
            }

            //return orderCoffe;

        }
        public static int GetQuantity()
        {
        inputQuantityDigit:
            System.Console.WriteLine("Укажите необходимое количество порций");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var quantity))
                {
                    Console.WriteLine("Ну куда ты буквы жамкаешь? Нужно цифами ввести количество кофе.");
                }
                else if (quantity == 0)
                {
                    System.Console.WriteLine("Что бы сформировать заказ, нужно указть число больше чем 0");
                    goto inputQuantityDigit;
                }
                else
                {
                    return quantity;
                }
            }
            // string inputQuantity = Console.ReadLine();
            // int quantity = Convert.ToInt32(inputQuantity);
            // if (quantity == 0)
            // {
            //     System.Console.WriteLine("что бы сформировать заказ, нужно указть число больше чем 0");
            //     goto inputQuantityDigit;
            // }
            // else
            // {
            // return quantity;
            // }
        }
        public static int GetPresummOrder(int a, int b) => a + b;
        // {
        //     // int preSummOrder;
        //     // preSummOrder = a+b;
        //     // return preSummOrder;
        // }
    }
}
