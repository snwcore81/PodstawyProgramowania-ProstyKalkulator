using System;

namespace ProstyKalkulator
{
    class Program
    {
        static void MenuOperacji()
        {
            Console.WriteLine("0 - Wyjście z programu");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");
            Console.Write("Wybierz jedna z opcji:");
        }

        static float PodajLiczbeFloat()
        {
            float _fLiczba = 0f;

            while (true)
            {
                Console.Write("Podaj liczbę:");

                if (float.TryParse(Console.ReadLine(), out _fLiczba) == true)
                {
                    break;
                }
                Console.WriteLine("Co piszesz gamoniu!?");
            }

            return _fLiczba;
        }

        static void Main(string[] args)
        {
            // typ y = typ f ( x,y )

            float _fWynik = 0f;
            float _fLiczba = 0f;
            int _iOpcja = -1;

            _fWynik = PodajLiczbeFloat();

            while (true)
            {
                while (true)
                {
                    MenuOperacji();

                    if (int.TryParse(Console.ReadLine(), out _iOpcja) == true && _iOpcja >= 0 && _iOpcja <= 4)
                    {
                        break;
                    }

                    Console.WriteLine("Serio... ??");
                }

                if (_iOpcja == 0)
                    return;

                while (true)
                {
                    Console.Write("Podaj drugą liczbę:");

                    if (float.TryParse(Console.ReadLine(), out _fLiczba) == true)
                    {
                        break;
                    }
                    Console.WriteLine("Co piszesz gamoniu!?");
                }

                switch (_iOpcja)
                {
                    case 1: //dodawanie

                        Console.Write($"{_fWynik} + {_fLiczba} = ");

                        _fWynik = _fWynik + _fLiczba;

                        Console.WriteLine($"{_fWynik}");

                        break;

                    case 2: //odejmowanie

                        Console.Write($"{_fWynik} - {_fLiczba} = ");

                        _fWynik = _fWynik - _fLiczba;

                        Console.WriteLine($"{_fWynik}");


                        break;

                    case 3: //mnozenie

                        Console.Write($"{_fWynik} * {_fLiczba} = ");

                        _fWynik = _fWynik * _fLiczba;

                        Console.WriteLine($"{_fWynik}");

                        break;

                    case 4: //dzielenie

                        if (_fLiczba != 0.0f)
                        {
                            Console.Write($"{_fWynik} / {_fLiczba} = ");

                            _fWynik = _fWynik / _fLiczba;

                            Console.WriteLine($"{_fWynik}");
                        }
                        else
                        {
                            Console.WriteLine("Nie wolno dzielić przez zero! :P");
                        }
                    
                    break;
                }
            }
        }
    }
}
