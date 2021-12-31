// 3. 
// *Для двух строк написать метод, определяющий, 
// является ли одна строка перестановкой другой.
// Например: badc являются перестановкой abcd.

using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.Write("Введите первую строку: ");
        String a = new String(Console.ReadLine());
        Console.Write("Введите вторую строку: ");
        String b = new String(Console.ReadLine());
        bool res = false;
        if (a.Length != b.Length)
        {
            res = false;


        }
        else
        {
            Char[] m = a.ToCharArray();
            Char[] k = b.ToCharArray();
            Array.Sort(m);
            Array.Sort(k);
            res = true;
            for (int i = 0; i < k.Length; i++)
            {
                if (m[i] != k[i])
                {
                    res = false;
                    break;
                }

            }


        }
        if (res)
        {
            Console.WriteLine("Да: одна строка является перестановкой другой.");
        }
        else
        {
            Console.WriteLine("Нет: одна строка не является перестановкой другой.");
        }
    }


}
