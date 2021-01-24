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
            //int summ;
            //int addToOrder;
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
            System.Console.WriteLine("Приятно познакомиться {0}", userName);
            int choice = Methods.GetOrderCoffe();
            int quantity = Methods.GetQuantity();
            preSumm = Methods.GetSummOrder(choice, quantity);
            System.Console.WriteLine("{0}, Вы  добавили к заказу {1} кофе на сумму {2}", userName, quantity, preSumm);
        // initialiseAddOrder:
        //     System.Console.WriteLine("Хотите добавить еще кофе к заказу? 1. - ДА. 2. - НЕТ");
            // string inputAddToOrder = Console.ReadLine();
            // int addToOrder = Convert.ToInt32(inputAddToOrder);
            // if (addToOrder == 1)
            // {
            //     summ = preSumm + Methods.GetSummOrder(Methods.GetOrderCoffe(), Methods.GetQuantity());
            //     System.Console.WriteLine("{0}, Вы  добавили к заказу {1} кофе на сумму {2}", userName, quantity, preSumm);
            //     System.Console.WriteLine("Общая сумма заказа {0} руб.", summ);
            //     goto initialiseAddOrder;

            // }

            // while (true)
            // {
            //     if (!int.TryParse(Console.ReadLine(), out addToOrder))
            //     {
            //         Console.WriteLine("Ну куда ты буквы жамкаешь? Нужно выбрать одну из двух цифр \n1 - что бы добавить новые позиции к заказу. \n2 - что бы подтвердить заказ и перейти к оплате");
            //     }
            //     else if (addToOrder == 1)
            //     {
            //         summ = preSumm + Methods.GetSummOrder(Methods.GetOrderCoffe(), Methods.GetQuantity());
            //         System.Console.WriteLine("{0}, Вы  добавили к заказу {1} кофе на сумму {2}", userName, quantity, preSumm);
            //         System.Console.WriteLine("Общая сумма заказа {0} руб.", summ);
            //         goto initialiseAddOrder;
            //     }
            //     else if (addToOrder == 2)
            //     {
            //         System.Console.WriteLine ("Переходим к оплате");
            //         //goto endOrder;
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Ты как будто читать не умеешь. Всего 2 кнопки: \n1 - сделать заказ.  \n2 - завершить работу аппарата.");
            //         goto initialiseOrder;
            //     }
            // }


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
