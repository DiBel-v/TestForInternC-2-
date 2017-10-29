using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            string cipher;
            int amount;
        TryAgain:
            cipher = Console.ReadLine();
            foreach(char str in cipher)
            {
                if((str!='?') && (str!='-') && (str!='.') && (cipher.Length > 4))
                {
                    Console.WriteLine("Строка имеет неверный формат, попробуйте ввести заново: ");
                    goto TryAgain;
                }
            }
            amount = cipher.Length;
            pr.morze(amount, cipher);
            Console.ReadKey();
        }

        public void morze(int amount, string cipher)
        {
            char[] words = new char[16];
            while (true)
            {
                //Используем свитч, чтобы разбить провкерку на 4 части
                switch (amount) {
                    //Если кол-во знаков в строке равняется 1
                    case 1:
                        if (cipher == ".") { words[0] = 'E'; break; }
                        if (cipher == "-") { words[0] = 'T'; break; }
                        if (cipher == "?")
                        {
                            words[0] = 'E';
                            words[1] = 'T';
                            break;
                        }
                        break;
                    //Если кол-во знаков в строке равняется 2
                    case 2:
                        if (cipher[0] == '.')
                        {
                            if (cipher[1] == '.') { words[0] = 'I'; break; }
                            if (cipher[1] == '-') { words[0] = 'A'; break; }
                            if (cipher[1] == '?')
                            {
                                words[0] = 'I';
                                words[1] = 'A';
                                break;
                            }
                        }
                        if (cipher[0] == '-')
                        {
                            if (cipher[1] == '.') { words[0] = 'N'; break; }
                            if (cipher[1] == '-') { words[0] = 'M'; break; }
                                if (cipher[1] == '?')
                            {
                                words[0] = 'N';
                                words[1] = 'M';
                                break;
                            }
                         
                        }
                        if (cipher[0] == '?')
                        {
                            if (cipher[1] == '.')
                            {
                                words[0] = 'I';
                                words[1] = 'N';
                                break;
                            }
                            if (cipher[1] == '-')
                            {
                                words[0] = 'A';
                                words[1] = 'M';
                                break;
                            }
                            if (cipher[1] == '?')
                            {
                                words[0] = 'I';
                                words[1] = 'A';
                                words[2] = 'N';
                                words[3] = 'M';
                                break;
                            }

                        }
                        break;
                    //Если кол-во знаков в строке равняется 3
                    case 3:
                        //Первый знак это "."
                        if (cipher[0] == '.')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.') { words[0] = 'S'; break; }
                                if (cipher[2] == '-') { words[0] = 'U'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'S';
                                    words[1] = 'U';
                                    break;
                                }
                            }
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.') { words[0] = 'R'; break; }
                                if (cipher[2] == '-') { words[0] = 'W'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'R';
                                    words[1] = 'W';
                                    break;
                                }
                            }
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    words[0] = 'S';
                                    words[1] = 'R';
                                    break;
                                }
                                if (cipher[2] == '-')
                                {
                                    words[0] = 'U';
                                    words[1] = 'W';
                                    break;
                                }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'S';
                                    words[1] = 'U';
                                    words[2] = 'R';
                                    words[3] = 'W';
                                    break;
                                }
                            }
                        }

                        //Первый знак это "-"
                        if (cipher[0] == '-')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.') { words[0] = 'D'; break; }
                                if (cipher[2] == '-') { words[0] = 'K'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'D';
                                    words[1] = 'K';
                                    break;
                                }
                            }
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.') { words[0] = 'G'; break; }
                                if (cipher[2] == '-') { words[0] = 'O'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'G';
                                    words[1] = 'O';
                                    break;
                                }
                            }

                            //Это можно вынести, все, где .?? и -??, .???, ..?? и тд
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    words[0] = 'D';
                                    words[1] = 'G';
                                    break;
                                }
                                if (cipher[2] == '-')
                                {
                                    words[0] = 'K';
                                    words[1] = 'O';
                                    break;
                                }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'D';
                                    words[1] = 'K';
                                    words[2] = 'G';
                                    words[3] = 'O';
                                    break;
                                }
                            }
                        }
                        if (cipher[0] == '?')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.') { words[0] = 'S'; words[1] = 'D'; break; }
                                if (cipher[2] == '-') { words[0] = 'U'; words[1] = 'K'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'S';
                                    words[1] = 'U';
                                    words[2] = 'D';
                                    words[3] = 'K';
                                    break;
                                }
                            }
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.') { words[0] = 'R'; words[1] = 'G'; break; }
                                if (cipher[2] == '-') { words[0] = 'W'; words[1] = 'O'; break; }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'R';
                                    words[1] = 'W';
                                    words[0] = 'G';
                                    words[1] = 'O';
                                    break;
                                }
                            }
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    words[0] = 'S';
                                    words[1] = 'R';
                                    words[2] = 'D';
                                    words[3] = 'G';
                                    break;
                                }
                                if (cipher[2] == '-')
                                {
                                    words[0] = 'U';
                                    words[1] = 'W';
                                    words[2] = 'K';
                                    words[3] = 'O';
                                    break;
                                }
                                if (cipher[2] == '?')
                                {
                                    words[0] = 'S';
                                    words[1] = 'U';
                                    words[2] = 'R';
                                    words[3] = 'W';
                                    words[0] = 'D';
                                    words[1] = 'K';
                                    words[2] = 'G';
                                    words[3] = 'O';
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:

                        //Первый элемент "."
                        if (cipher[0] == '.')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.') { words[0] = 'H'; break; }
                                    if (cipher[3] == '-') {words[0] = 'V'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if ((cipher[3] == '.') || (cipher[3] == '?')) { words[0] = 'F'; break; }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'F';
                                        break;
                                    }
                                    if (cipher[3] == '-') { words[0] = 'V'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'F';
                                        break;
                                    }
                                }
                            }
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.')
                                {
                                    if ((cipher[3] == '.') || (cipher[3] == '?')) { words[0] = 'L'; break; }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.') { words[0] = 'P'; break; }
                                    if (cipher[3] == '-') { words[0] = 'J'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'P';
                                        words[1] = 'J';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'P';
                                        break;
                                    }
                                    if (cipher[3] == '-') words[0] = 'J';
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'P';
                                        words[2] = 'J';
                                        break;
                                    }
                                }
                            }
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'L';
                                        break;
                                    }
                                    if (cipher[3] == '-') { words[0] = 'V'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'L';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'P';
                                        break;
                                    }
                                    if (cipher[3] == '-') { words[0] = 'J'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'P';
                                        words[2] = 'J';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'F';
                                        words[2] = 'L';
                                        words[3] = 'P';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'V';
                                        words[1] = 'J';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'F';
                                        words[3] = 'L';
                                        words[4] = 'F';
                                        words[5] = 'J';
                                        break;
                                    }
                                }
                            }
                        }

                        //Начинается со знака "-"
                        if (cipher[0] == '-')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.') { words[0] = 'B'; break; }
                                    if (cipher[3] == '-') { words[0] = 'X'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'X';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.') { words[0] = 'C'; break; }
                                    if (cipher[3] == '-') { words[0] = 'Y'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'C';
                                        words[1] = 'Y';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'C';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'X';
                                        words[1] = 'Y';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'C';
                                        words[2] = 'X';
                                        words[3] = 'Y';
                                        break;
                                    }

                                }
                            }
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.') { words[0] = 'Z'; break; }
                                    if (cipher[3] == '-') { words[0] = 'Q'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'Z';
                                        words[1] = 'Q';
                                        break;
                                    }
                                }
                                
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.') { words[0] = 'Z'; break; }
                                    if (cipher[3] == '-') {words[0] = 'Q'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'Z';
                                        words[1] = 'Q';
                                        break;
                                    }
                                }
                            }
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'X';
                                        words[1] = 'Q';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'X';
                                        words[2] = 'Z';
                                        words[3] = 'Q';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.') { words[0] = 'C'; break; }
                                    if (cipher[3] == '-') { words[0] = 'Y'; break; }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'C';
                                        words[1] = 'Y';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'C';
                                        words[2] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'X';
                                        words[1] = 'Y';
                                        words[2] = 'Q';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'B';
                                        words[1] = 'X';
                                        words[2] = 'C';
                                        words[3] = 'Y';
                                        words[4] = 'Z';
                                        words[5] = 'Q';
                                        break;
                                    }
                                }
                            }
                        }

                        //Первый элемент "?", перебираем значения, которое можгут начинаться с этого элемента
                        if (cipher[0] == '?')
                        {
                            if (cipher[1] == '.')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'B';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'V';
                                        words[1] = 'X';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'B';
                                        words[3] = 'X';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'C';
                                        break;
                                    }
                                    if (cipher[3] == '-') {
                                        words[0] = 'Y';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'C';
                                        words[2] = 'Y';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'F';
                                        words[2] = 'B';
                                        words[3] = 'C';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'V';
                                        words[1] = 'X';
                                        words[2] = 'Y';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'F';
                                        words[3] = 'B';
                                        words[4] = 'X';
                                        words[5] = 'C';
                                        words[6] = 'Y';
                                        break;
                                    }

                                }
                            }

                            
                            if (cipher[1] == '-')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'Q';
                                        break;
                                    }

                                        if (cipher[3] == '?')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'Z';
                                        words[2] = 'Q';
                                        break;
                                    }
                                }
                                
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'P';
                                        words[2] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'J';
                                        words[1] = 'Q';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'L';
                                        words[1] = 'P';
                                        words[2] = 'J';
                                        words[3] = 'Z';
                                        words[4] = 'Q';
                                        break;
                                    }
                                }
                            }
                            if (cipher[1] == '?')
                            {
                                if (cipher[2] == '.')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'L';
                                        words[2] = 'B';
                                        words[3] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'V';
                                        words[1] = 'X';
                                        words[2] = 'Q';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'L';
                                        words[3] = 'B';
                                        words[4] = 'X';
                                        words[5] = 'Z';
                                        words[6] = 'Q';
                                        break;
                                    }
                                }
                                if (cipher[2] == '-')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'P';
                                        words[2] = 'C';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'J';
                                        words[1] = 'Y';
                                        break;
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'F';
                                        words[1] = 'P';
                                        words[2] = 'J';
                                        words[3] = 'C';
                                        words[4] = 'Y';
                                        break;
                                    }
                                }
                                if (cipher[2] == '?')
                                {
                                    if (cipher[3] == '.')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'F';
                                        words[2] = 'L';
                                        words[3] = 'P';
                                        words[4] = 'B';
                                        words[5] = 'C';
                                        words[6] = 'Z';
                                        break;
                                    }
                                    if (cipher[3] == '-')
                                    {
                                        words[0] = 'V';
                                        words[1] = 'J';
                                        words[2] = 'X';
                                        words[3] = 'Y';
                                        words[4] = 'Q';
                                    }
                                    if (cipher[3] == '?')
                                    {
                                        words[0] = 'H';
                                        words[1] = 'V';
                                        words[2] = 'F';
                                        words[3] = 'L';
                                        words[4] = 'P';
                                        words[5] = 'J';
                                        words[6] = 'B';
                                        words[7] = 'X';
                                        words[8] = 'C';
                                        words[9] = 'Y';
                                        words[10] = 'Z';
                                        words[11] = 'Q';
                                        break;
                                    }

                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong length");
                        break;
                }
                break;
            }
            //Перебираем значения в массиве и выводим их на экран
            foreach(char i in words)
            {
                Console.Write(i + " ");
            }
        }
    }
}
