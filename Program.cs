using System;

namespace SimuladorDeMarianoRoscioliCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora12, hora24, min, seg;
            string indicador;

            Console.WriteLine("Ingrese la hora utilizando 2 digitos: ");
            hora12= int.Parse (Console.ReadLine());

            if (hora12 <= 12 && hora12 >= 0)
            {
                Console.WriteLine("Ingrese los minutos utilizando 2 digitos: ");
                min = int.Parse(Console.ReadLine());

                if (min >= 0 && min <= 59)
                {
                    Console.WriteLine("Ingrese los segundos utilizando 2 digitos: ");
                    seg = int.Parse(Console.ReadLine());

                    if (seg >= 0 && seg <= 59)
                    {
                        Console.WriteLine("Indique si es antes o pasado el mediodia");
                        Console.WriteLine("Antes (am) opcion: A");
                        Console.WriteLine("Pasado (pm) opcion: P");
                        indicador = Console.ReadLine();


                        if (indicador.ToUpper() == "A")
                        {
                            Console.WriteLine($"La hora en formato digital es: {hora12}:{min}:{seg} am");
                            Console.WriteLine($"La hora en formato militar es: {hora12}:{min}:{seg} hs");

                           
                        }
                        else
                        {
                            if (indicador.ToUpper() == "P")
                            {
                                Console.WriteLine($"La hora en formato digital es: {hora12}:{min}:{seg} pm");
                                hora24 = hora12 + 12;
                                Console.WriteLine($"La hora en formato militar es: {hora24}:{min}:{seg} hs");

                            }
                            else
                            {
                                Console.WriteLine("Alguno de los datos ingresados es erroneo");
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los segundos ingresados son incorrectos");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Los minutos ingresados son incorrectos");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("La hora ingresada es invalida");
                Console.ReadLine();

            }
                
            Console.ReadKey();
        }
    }
 }

