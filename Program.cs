namespace Ejercicio2Obligatorio
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el tamaño del array:");

            int tamaño;

            do
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out tamaño))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Formato no válido. Debe ingresar un número entero.");
                    Console.Write("Ingrese un formato válido: ");
                }
            } while (true);


            Console.WriteLine("Número entero capturado.");

        

        int[] array = new int[tamaño];

            Console.WriteLine($"Array de tamaño {tamaño} creado.");


            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Ingresa un valor para la posición {i + 1}:");

                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                    Console.Write($"Ingrese el valor para la posición {i + 1}: ");
                }
            }

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Array ordenado de mayor a menor.");

            foreach (int numero in array)
            {
                Console.Write(numero + " ");
            }

            Console.ReadLine();

        }

        
    }
}

