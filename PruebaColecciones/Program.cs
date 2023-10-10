// Crear una colección genérica de 5 frutas.

// Mostrar la información de la colección (tamaño, elementos)

// Buscar en la colección la fruta naranja.

// Insertar por índice una nueva fruta e imprimir.

// Remover la fruta insertada.

// Remover la fruta con el indice 0 e imprimir.

using System.Collections.ObjectModel;

Collection<string> frutas = new Collection<string>();

frutas.Add("Manzana");
frutas.Add("Melón");
frutas.Add("Naranja");
frutas.Add("Uvas");
frutas.Add("Sandía");

Console.WriteLine("Tamaño de la colección." + frutas.Count);
Console.WriteLine("Elementos de la colección.");

foreach (string fruta in frutas)
{
    Console.WriteLine(frutas);
}

bool encontrar = frutas.Contains("Naranja");

if (encontrar)
{
    Console.WriteLine("La fruta Naranja se encuentra en la colección.");
}

else
{
    Console.WriteLine("La fruta Naranja no se encuentra en la colección");
}

frutas.Insert(2, "Banana");

Console.WriteLine("Fruta insertada en la posición 2: " + frutas[2]);

frutas.Remove("Sandía");
frutas.RemoveAt(0);
Console.WriteLine("Tamaño de la colección: " + frutas.Count);
Console.WriteLine("Elementos de la colección.");

foreach(string fruta in frutas)
{
    Console.WriteLine(fruta);
}