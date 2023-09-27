//1.Realice un programa que permita ingresar una cadena de caracteres y se evalúe su
//tamaño, si el tamaño es menor que 25 caracteres que rellene con el carácter signo
//de dólar ($), puede ser relleno por la derecha o por la izquierda

public class Ejercicio1
{
    public static void Main(string[] args)
    {
        // Se le pide ingresar al usuario los caracteres 
        Console.WriteLine("Por favor Ingrese una cadena de caracteres:");
        string cadena_caracteres = Console.ReadLine();

        if (cadena_caracteres.Length < 25)
        {
            // Relleno por la derecha 
            cadena_caracteres = cadena_caracteres.PadRight(25, '$');
        }

        Console.WriteLine("Su resultado es: " + cadena_caracteres);
    }
}

//Hecho por Josue Bryan Hernandez Zelaya