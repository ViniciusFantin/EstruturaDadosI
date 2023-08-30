using System;

public class program{
    public static void Main()
    {
        int[] numeros = new int[10];
        for (int p = 0; p < numeros.Length; p++)
        {
            Console.WriteLine("Digite um número maior que 0");
            numeros[p] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("\n\nOs números que você digitou em ordem");
        foreach (var num in numeros )
        {
            Console.WriteLine(num);
        }
        {
            
        }


    
    }
}
