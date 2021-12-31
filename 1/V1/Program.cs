// 1.
// Создать программу, которая будет
// проверять корректность ввода логина. 
// Корректным логином будет
// строка от 2 до 10 символов,
// содержащая только буквы латинского
// алфавита или цифры, при этом 
// цифра не может быть первой:
// а) без использования регулярных выражений;
using System;
using System.Text;

Console.Write("Введите логин:");
StringBuilder sb = new StringBuilder(Console.ReadLine());
bool res = false;
while (res == false)
{
    if (sb.Length > 2 && sb.Length < 10)
    {

        char a = sb[0];
        if (char.IsNumber(a) == false)
        {
            for (int i = 1; i < sb.Length; i++)
            {
                if (char.IsNumber(sb[i]) | char.IsLetter(sb[i]))
                {
                    res = true;
                }
                else
                {
                    res = false;
                    Console.Write("Логин должен содержать только буквы или цифры . Введите другой:");
                    sb = new StringBuilder(Console.ReadLine());
                }
            }

        }
        else
        {
            Console.Write("Цифра в логине не может быть первой. Введите другой:");
            sb = new StringBuilder(Console.ReadLine());
        }

    }
    else
    {
        Console.Write("Логин должен быть больше 2 и меньше 10. Введите другой:");
        sb = new StringBuilder(Console.ReadLine());
        res = false;
    }

}
Console.Write("Логин отличный, спасибо :-)");
