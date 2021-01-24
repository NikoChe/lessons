using System;

namespace coffestation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 10, 50, 100, 500, 1000, 5000 };
            string userName = "";
            int preSumm;
            int summ = 0;
            int bill;
            int quantityBill;
            int summBill;
            Console.WriteLine("В нашем аппарате вы можете приобрести: \n1. Эспрессо - 50 руб. \n2. Кофе Американо - 100 руб. \n3. Латте/Капучино маленький - 150 руб. \n4. Латте/Капучино средний - 200 руб. \n5. Латте/Капучино большой - 250 руб");
        initialiseOrder:
            System.Console.WriteLine("Желаете приобрести напиток? 1 - Да. 2 - Нет");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var order))
                {
                    Console.WriteLine("Ну куда ты буквы жамкаешь? Нужно выбрать одну из двух цифр \n1 - что бы сделать заказ. \n2 - что бы завершить работу аппарата");
                }
                else if (order == 1)
                {
                    System.Console.WriteLine("Аппарат готов принят ваш заказ");
                    goto GetName;
                }
                else if (order == 2)
                {
                    System.Console.WriteLine("Если передумаете кофе аппарат будет ждать Вас на этом же месте. До встречи");
                    goto endOrder;
                }
                else
                {
                    System.Console.WriteLine("Ты как будто читать не умеешь. Всего 2 кнопки: \n1 - сделать заказ.  \n2 - завершить работу аппарата.");
                    goto initialiseOrder;
                }
            }
        GetName:
            System.Console.WriteLine("Как тебя зовут сладенький?:-)");
            userName = Console.ReadLine();
            System.Console.WriteLine("Приятно познакомиться, {0}", userName);
        initialiseAddOrder:
            Console.WriteLine("Какой кофе выбрали?: \n1. Эспрессо - 50 руб. \n2. Кофе Американо - 100 руб. \n3. Латте/Капучино маленький - 150 руб. \n4. Латте/Капучино средний - 200 руб. \n5. Латте/Капучино большой - 250 руб");
            int choice = Methods.GetOrderCoffe();
            int quantity = Methods.GetQuantity();
            preSumm = Methods.GetSummChoice(choice, quantity);
            summ += preSumm;
            System.Console.WriteLine("{0}, Вы  добавили к заказу {1} кофе на сумму {2}", userName, quantity, preSumm);
            System.Console.WriteLine("Общая сумма заказа {0} руб.", summ);
        plusToOrder:
            System.Console.WriteLine("Хотите добавить еще кофе к заказу? \n1. - ДА. \n2. - НЕТ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var addtoOrder))
                {
                    Console.WriteLine("Ну куда ты буквы жамкаешь? Нажимай \n1. - Для добавления кофе к заказу. \n2. - Для оформления и оплаты заказа.");
                }
                else if (addtoOrder == 1)
                {
                    goto initialiseAddOrder;
                }
                else if (addtoOrder == 2)
                {
                    System.Console.WriteLine("{0}, Ваш заказ на сумму {2}", userName, quantity, summ);
                    goto addBill;
                }
                else
                {
                    System.Console.WriteLine("\n1. - Для добавления кофе к заказу. \n2. - Для оформления и оплаты заказа.");
                    goto plusToOrder;
                }
            }

        addBill:
            System.Console.WriteLine("Наш аппарат принимает купюры следующих номиналов: \n1.- 10 рублей \n2. - 50 рублей \n3. - 100 рублей \n4. - 500 рублей \n5. - 1000 рублей, \n6. - 5000 рублей");
        choiceBill:
            System.Console.WriteLine("Выберите номинал вашей купюры, нажав цифру от 1 до 6");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var choiceBill))
                {
                    System.Console.WriteLine("Выбор номинала купюр производится нажатием кнопок от 1 до 6. А не буквами, как ты сейчас нажал.");
                }
                else if (choiceBill >= 1 & choiceBill <= 6)
                {
                    bill = coins [choiceBill-1];
                    System.Console.WriteLine("Вы вносите купюры номиналом {0} рублей.", bill);
                    goto inputQuantityBill;
                }
                else
                {
                    System.Console.WriteLine("Выбор номинала купюр производится нажатием кнопок от 1 до 6.");
                    goto choiceBill;
                }
            
            }
            inputQuantityBill:
            System.Console.WriteLine("Укажите количество купюр");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var quantityBillInput))
                {
                    System.Console.WriteLine("Количество купюр нужно водить целыми числами. Например: 1, 5, 100 ит.д");
                }
                else if (quantityBillInput == 0)
                {
                    System.Console.WriteLine("Количество купюр не может быть равным нулю");
                    goto inputQuantityBill;
                }
                else
                {
                    quantityBill = quantityBillInput;
                    break;
                }
            }
            summBill = bill * quantityBill;
            System.Console.WriteLine("вы внесли купюр на сумму {0} рублей", summBill);
            if (summBill == summ)
            {
                System.Console.WriteLine("Вы внесли необходимую сумму. Ожидайте приготовления напитка");
            }
            else if (summBill > summ)
            {
                int surrenger = summBill - summ;
                System.Console.WriteLine("Вы внесли сумму больше, чем нужно. Ваша сдача {0} рублей.", surrenger);
            }
            else
            {
                System.Console.WriteLine("Зафиксировна попытка обмана продавца. Внессенные деньги конфискованы. Полиция уже выехала. БЕГИ!!!");
            }


        endOrder:
            if (string.IsNullOrEmpty(userName))
            {
                System.Console.WriteLine("Ждем Вас вновь");
            }
            else
            {
                System.Console.WriteLine("Ждем Вас вновь {0}", userName);
            }
            Console.ReadKey();
        }

    }
}
