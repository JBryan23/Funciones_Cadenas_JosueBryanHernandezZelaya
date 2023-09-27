//3.Dada la siguiente cadena de caracteres: “MI MAMA ME MIMA, AMO A MI MAMA”
//realizar lo siguiente
//● convertir la frase a letras minúsculas
//● separar la frase cada vez que se encuentre un espacio en blanco
//● si la longitud de la frase separada es menor que 3, concatenar la frase con el
//signo de porcentaje %
public class ejercicio3
{
    public static void Main(string[] args)
    {
        // Convertir la frase a letras minusculas
        string Cadena_Caracteres = "MI MAMA ME MIMA, AMO A MI MAMA";
        Console.WriteLine("Frase normal: " + Cadena_Caracteres);
        Console.WriteLine("Frase convertido a minúsculas: " + Cadena_Caracteres.ToLower());
        Console.WriteLine();
        Cadena_Caracteres = Cadena_Caracteres.ToLower();

        //Separar la frase cada vez que se encuentre un espacio en blanco
        string[] Palabras = Cadena_Caracteres.Split(' ');

        for (int i = 0; i < Palabras.Length; i++)
        {
            // longitud de la cadena de caracteres separada es menor que 3, concatenar la frase con el signo de porcentaje %
            if (Palabras[i].Length < 3)
            {
                Palabras[i] += "%";
            }
        }

        // Frase ya seperada con sus longitud
        string Nueva_CadenaCaracteres = string.Join(" ", Palabras);

        Console.WriteLine("Frase normal (Previamente convertida en minúsculas): " + Cadena_Caracteres);
        Console.WriteLine("Frase procesada: " + Nueva_CadenaCaracteres);
    }
}
// Hecho por Josue Bryan Hernandez Zelaya