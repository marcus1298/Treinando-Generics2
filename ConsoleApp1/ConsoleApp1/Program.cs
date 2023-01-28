public static class Comparador<T>
{
    public static bool SãoIguais(T objeto1, T objeto2)
    {
        return objeto1.Equals(objeto2);
    }
}
class Program
{


    static void Main(string[] args)
    {
        string nome1 = "Marcus";
        string nome2 = "Lucas";
        Console.WriteLine(Comparador<string>.SãoIguais(nome1, nome2)); //output: false

        int num1 = 1;
        int num2 = 2;
        Console.WriteLine(Comparador<int>.SãoIguais(num1, num2)); //output: false

        double decimal1 = 3.14;
        double decimal2 = 3.14;
        Console.WriteLine(Comparador<double>.SãoIguais(decimal1, decimal2)); //output: true
    }
}