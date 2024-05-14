var incremento = Convert.ToInt32(Console.ReadLine());
var lista = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

var final = new int [lista.Length];

var contador = 0;

foreach(var numero in lista)
{
    if(incremento > 0)
    {
        var nuevoIndice = (contador + incremento) - lista.Length;
        final[nuevoIndice < 0 ? (lista.Length - Math.Abs(nuevoIndice)) : nuevoIndice]= numero;
    }
    contador++;
}


// Impresión de valores

string salida = "";

foreach(var numero in final)
{
    salida+= numero + ",";
}

Console.WriteLine(salida.Substring(0,salida.Length-1));