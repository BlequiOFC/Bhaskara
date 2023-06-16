Console.Clear();

int a, b , c, delta;
double bhaskara1, bhaskara2;

Console.WriteLine($"--- Equação do 2º Grau ---\n");

Console.Write("a = ");
a = Convert.ToInt16(Console.ReadLine());

Console.Write("b = ");
b = Convert.ToInt16(Console.ReadLine());

Console.Write("c = ");
c = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();
Console.ReadKey();

if (a == 0)
{
    Console.WriteLine("O valor de A não pode ser igual a zero.");
}
else
{

Console.WriteLine("Formúla de Delta:");
Console.WriteLine("Delta = b² - 4.a.c");

Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Equação de Delta:");
Console.WriteLine($"Delta = {b}² - 4.{a}.{c}\n");

delta = b * b - 4 * a * c;
Console.WriteLine($"Delta resulta em: {delta}");

Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Formúla de Bhaskara:");
Console.WriteLine("-b +- √delta / 2.a");

Console.WriteLine();
Console.ReadKey();

if (delta < 0)
{
    Console.Write("Infelizmente a equação não pode ser concluida pois não existe raíz de número negativo.");
}
else
{
    Console.WriteLine("Equação de Bhaskara:");
    Console.WriteLine($"{b * -1} +- √{delta} / 2.{a}");

    Console.WriteLine();
    Console.ReadKey();  

    bhaskara1 = ((b * -1) + Math.Sqrt(delta)) / (2 * a); 
    bhaskara2 = ((b * -1) - Math.Sqrt(delta)) / (2 * a); 

    Console.WriteLine("Os resultados são: ");
    Console.WriteLine($"x¹ = {bhaskara1.ToString("0.00")}");
    Console.WriteLine($"x² = {bhaskara2.ToString("0.00")}");

    Console.WriteLine();
}
}
;