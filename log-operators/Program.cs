using System;

namespace log_operators
{
    class Program
    {
        static void Main()
        {
            int price = 0;
            int discountQuantity = 0;
            int discountSumm = 0;
            int summ = 0;
            int bill = 0;
            int quantityBill = 0;
            int discountSummPercent = 0;
            int discountQuantityPercent = 0;
            
            Console.WriteLine("У нас вы можете приобрести: \n1. - Кофе маленький (100 руб.) \n2. - Кофе средний (150 руб.) \n3. - Кофе большой (200 руб.)");
            System.Console.WriteLine("Сделайте свой выбор нажав клавижу 1, 2 или 3:");
            string choiceInput = Console.ReadLine ();
            int choice = Convert.ToInt32 (choiceInput);
            switch (choice)
                {
                    case 1:
                        price = 100;
                        System.Console.WriteLine("Вы выбрали маленький кофе за 100 рублей.");
                        break;
                    case 2:
                        price = 150;
                        System.Console.WriteLine("Вы выбрали средний кофе за 150 рублей.");
                        break;
                    case 3:
                        price = 200;
                        System.Console.WriteLine("Вы выбрали большой кофе за 200 рублей.");
                        break;
                    default:
                        System.Console.WriteLine("Вы выбрали несуществующий товар. Попробуйте еще раз.");
                        return;
                }
            System.Console.WriteLine("Вам доступно 2 вида скидки: за количество заказанного товара и по сумме чека. Скидки суммируются");
            System.Console.WriteLine("Укажите необходимое количество товара:");
            string quantityInput = Console.ReadLine ();
            int quantity = Convert.ToInt32 (quantityInput);
            int summForCoffe = price * quantity;
            if (quantity >= 5 & quantity <= 9)
                {
                    discountQuantityPercent = 10;
                }
                else if (quantity >= 10 & quantity <= 20)
                {
                    discountQuantityPercent = 20;
                }
                else if (quantity >= 21)
                {
                    discountQuantityPercent = 30;
                }
                else discountQuantityPercent =0;

            if (summForCoffe >= 500 & summForCoffe <=1500)
                {
                    discountSummPercent = 10;
                }
                else if (summForCoffe >= 1501 & summForCoffe <= 2000)
                {
                    discountSummPercent = 20;
                }
                else if (summForCoffe >= 2001)
                {
                    discountSummPercent = 30;
                }
                else discountSummPercent =0;
            discountQuantity = (summForCoffe/100)* discountSummPercent;
            discountSumm = (summForCoffe/100)* discountQuantityPercent;
            summ= summForCoffe-discountQuantity-discountSumm;
            System.Console.WriteLine("Вы выбрали {0} порций кофе по цене {1} рублей за порцию на общую сумму {2} рублей.", quantity, price, summForCoffe);
            System.Console.WriteLine("Ваша скидка по количеству заказанного товара {0} рублей.", discountQuantity);
            System.Console.WriteLine("Ваша скидка от суммы заказа {0} рублей.", discountSumm);
            System.Console.WriteLine("Итоговая сумма вашего заказа {0} рублей.", summ);
            System.Console.WriteLine("Наш аппарат принимает купюры следующих номиналов: \n1.- 10 рублей \n2. - 50 рублей \n3. - 100 рублей \n4. - 500 рублей \n5. - 1000 рублей, \n6. - 5000 рублей");
            System.Console.WriteLine("выберите номинал вашей купюры, нажав цифру от 1 до 6");
            string choiceBillInput = Console.ReadLine ();
            int choiceBill = Convert.ToInt32 (choiceBillInput);
            switch (choiceBill)
            {
                case 1:
                    System.Console.WriteLine("Ваша купюра 10 рублей");
                    bill = 10;
                    break;
                case 2:
                    System.Console.WriteLine("Ваша купюра 50 рублей");
                    bill = 50;
                    break;
                case 3:
                    System.Console.WriteLine("Ваша купюра 100 рублей");
                    bill = 100;
                    break;
                case 4:
                    System.Console.WriteLine("Ваша купюра 500 рублей");
                    bill = 500;
                    break;
                case 5:
                    System.Console.WriteLine("Ваша купюра 1000 рублей");
                    bill = 1000;
                    break;
                case 6:
                    System.Console.WriteLine("Ваша купюра 5000 рублей");
                    bill = 5000;
                    break;
                default:
                    System.Console.WriteLine("Вы выбрали не верный тип купюр");
                    break;
            }
            System.Console.WriteLine("Укажите количество купюр");
            string quantityBillInput = Console.ReadLine();
            quantityBill = Convert.ToInt32 (quantityBillInput);
            int summBill = bill*quantityBill;
            System.Console.WriteLine("вы внесли купюр на сумму {0} рублей", summBill);
            if (summBill == summ)
                {
                    System.Console.WriteLine("Вы внесли необходимую сумму. Ожидайте приготовления напитка");
                }
                else if (summBill > summ)
                {
                    int surrenger = summBill-summ;
                    System.Console.WriteLine("Вы внесли сумму больше, чем нужно. Ваша сдача {0} рублей.", surrenger);
                }
                else
                {
                    System.Console.WriteLine("Зафиксировна попытка обмана продавца. Внессенные деньги конфискованы. Полиция уже выехала. БЕГИ!!!");
                }
            Console.ReadKey ();

        }
    }
}
