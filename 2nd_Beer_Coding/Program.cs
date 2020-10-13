using System;

namespace _2nd_Beer_Coding
{
    /*Домашка
    Сделать прогу, которая загадывает 10 разных загадок
    просит ввести ответ и говорит правильно или нет
    в конце выводит сколько правильных ответов и сколько неправильных было у пользователя.
    как решите - пишите еще
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, ты запустил мою прогу для загадок, их будет 10шт.");
            Console.WriteLine("Отвечай одним словом с большой буквы. После каждой загадки программа скажет правильный был ответ или нет");
            Console.WriteLine("После каждой загадки программа скажет правильный был ответ или нет. Нажми любую клавишу что бы начать");
            Console.ReadKey();
            int counter = 0;

            Console.WriteLine("Загадка 1. Вы сидите в самолете, спереди вас лошадь, сзади автомобиль. Что это за место");
            string Input = Console.ReadLine();
            if (Input == "Карусель" || Input == "карусель" || Input == "КАРУСЕЛЬ")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал. Ничего, повезет дальше");
            }

            Console.WriteLine("Загадка 2. С когтями, а не птица, летит и матерится.");
            Input = Console.ReadLine();
            if (Input == "Электромонтер" || Input == "'электромонтер" || Input == "ЭЛЕКТРОМОНТЕР")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал. Ничего, дальше проще будут!");
            }

            Console.WriteLine("Загадка 3. Что может в одно и то же время стоять и ходить, висеть и стоять, ходит и лежать?");
            string Result = (Input == "Часы" || Input == "часы" || Input == "ЧАСЫ") ? "Правильно" : "Ты ошибся дружочек-пирожочек";
            if (Result == "Правильно") 
            {
                counter++;           
            }

            Console.WriteLine("Загадка 4. В каком городе спрятались мужское имя и сторона света?");
            Input = Console.ReadLine();
            if (Input == "Владивосток" || Input == "владивосток" || Input == "ВЛАДИВОСТОК")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else 
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 5. Человек при жизни получает это трижды: два раза абсолютно бесплатно, на третий раз ему приходится за это платить. Что это?");
            Input = Console.ReadLine();
            if (Input == "Зубы" || Input == "зубы" || Input == "ЗУБЫ")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 6. Какой знак нужно поставить между 6 и 7, чтобы результат оказался меньше 7 и больше 6?");
            Input = Console.ReadLine();
            if (Input == "Запятая" || Input == "запятая" || Input == "Запятую" || Input == "запятую")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 7. Не лёд, а тает, не лодка, а уплывает. Что это?");
            Input = Console.ReadLine();
            if (Input == "Зарплата" || Input == "зарплата")
            {
                Console.WriteLine("Правильно, теперь можешь немного поплакать.");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 8. Сколько программистов нужно, чтобы закрутить лампочку?");
            Input = Console.ReadLine();
            if (Input == "Ни одного" || Input == "ни одного")
            {
                Console.WriteLine("Правильно, это аппаратная проблема, программисты их не решают.");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 9. В каком слове «спрятался» напиток и природное явление?");
            Input = Console.ReadLine();
            if (Input == "Виноград" || Input == "виноград")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine("Загадка 10. Какое пиво не стоит покупать на курсы?");
            Input = Console.ReadLine();
            if (Input == "Пшеничное" || Input == "пшеничное" || Input == "Пшеничу" || Input == "пшеничку")
            {
                Console.WriteLine("Правильно");
                counter++;
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

            Console.WriteLine($"Вот и все загадки, а вот и твой результат {counter}/10.");
        }
    }
}
