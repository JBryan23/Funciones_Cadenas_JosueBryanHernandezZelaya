//2. Aplicar las funciones de cadenas vistas en clases para la codificación de un
//programa que permita ingresar al usuario 2 cadenas y que verifique a través de los
//métodos CompareTo() y Equals() si las cadenas son iguales, mostrando el mensaje
//según los resultados de la evaluación de cada método

public class Ejercicio2
{
    public static void Main()
    {
        //Ingresar al usuario 2 cadenas
        Console.WriteLine("Por favor escriba la primera cadena: ");
        string Cadena_Uno = Console.ReadLine();
        Console.WriteLine("Por favor escriba la segunda cadena: ");
        string Cadena_Dos = Console.ReadLine();
        Console.WriteLine();
        //Verificar a través de los métodos CompareTo() y Equals() si las cadenas son iguales
        //Usando el metodo Equals
        Console.WriteLine("Usando el metodo de comparacion Equals() "+ Cadena_Uno.Equals(Cadena_Dos));
        if (Cadena_Uno.Equals(Cadena_Dos) == false)
        {
            Console.WriteLine("Sus cadenas ingresadas no son iguales");
        }
        else
        {
            Console.WriteLine("Sus cadenas ingresadas son iguales");
        }
        Console.WriteLine();
        //Usando el metodo CompareTo
        int comparacion;
        Console.WriteLine("Usando el metodo de comparacion CompareTo() " + Cadena_Uno.CompareTo(Cadena_Dos));
        comparacion = Cadena_Uno.CompareTo(Cadena_Dos);
        if (Cadena_Uno.CompareTo(Cadena_Dos)==1 )
        {
            Console.WriteLine("Sus cadenas ingresadas no son iguales");
        }
        else
        {
            Console.WriteLine("Sus cadenas ingresadas son iguales");
        }

    }
}

// Hecho por Josue Bryan Hernandez Zelaya