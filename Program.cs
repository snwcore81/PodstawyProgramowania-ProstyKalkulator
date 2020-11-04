using System;

namespace ProstyKalkulator
{
    class Program
    {
        static void WyswietlMenu()
        {
            Console.WriteLine("0 - Wyjście z programu");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");
            Console.Write("Wybierz jedna z opcji:");
        }

        static int Menu()
        {
            int _iOpcja = 0;

            while (true)
            {
                WyswietlMenu();

                if (int.TryParse(Console.ReadLine(), out _iOpcja) == true && _iOpcja >= 0 && _iOpcja <= 4)
                {
                    break;
                }

                Console.WriteLine("Serio... ??");
            }

            return _iOpcja;
        }

        static float PodajLiczbeFloat(string a_sTekstWejsciowy, string a_sKomunikatBledu = "Co piszesz gamoniu ?!")
        {
            float _fLiczba = 0f;

            while (true)
            {
                Console.Write(a_sTekstWejsciowy);

                if (float.TryParse(Console.ReadLine(), out _fLiczba) == true)
                {
                    break;
                }
                Console.WriteLine(a_sKomunikatBledu);
            }

            return _fLiczba;
        }

        static float WykonajDzialanie(int a_iOpcja, float a_fLiczba1, float a_fLiczba2)
        {
            float _fWynik = 0f;

            switch (a_iOpcja)
            {
                case 1: //dodawanie

                    Console.Write($"{a_fLiczba1} + {a_fLiczba2} = ");

                    _fWynik = a_fLiczba1 + a_fLiczba2;

                    Console.WriteLine($"{_fWynik}");

                    break;

                case 2: //odejmowanie

                    Console.Write($"{a_fLiczba1} - {a_fLiczba2} = ");

                    _fWynik = a_fLiczba1 - a_fLiczba2;

                    Console.WriteLine($"{_fWynik}");


                    break;

                case 3: //mnozenie

                    Console.Write($"{a_fLiczba1} * {a_fLiczba2} = ");

                    _fWynik = a_fLiczba1 * a_fLiczba2;

                    Console.WriteLine($"{_fWynik}");

                    break;

                case 4: //dzielenie

                    if (a_fLiczba2 != 0.0f)
                    {
                        Console.Write($"{a_fLiczba1} / {a_fLiczba2} = ");

                        _fWynik = a_fLiczba1 / a_fLiczba2;

                        Console.WriteLine($"{_fWynik}");
                    }
                    else
                    {
                        Console.WriteLine("Nie wolno dzielić przez zero! :P");

                        _fWynik = a_fLiczba1;
                    }

                    break;
            }

            return _fWynik;
        }

        static void MojKalkulator()
        {
            float _fWynik = 0f;
            float _fLiczba = 0f;
            int _iOpcja = -1;

            _fWynik = PodajLiczbeFloat("Podaj liczbę:");

            while (true)
            {
                _iOpcja = Menu();

                if (_iOpcja == 0)
                    return;

                _fLiczba = PodajLiczbeFloat("Podaj drugą liczbę:", "Serio? Zastanów się.... :-/");

                _fWynik = WykonajDzialanie(_iOpcja, _fWynik, _fLiczba);
            }
        }

        static void Main(string[] args)
        {
            MojKalkulator();
        }
    }
}
