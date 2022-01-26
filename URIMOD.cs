using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int N, VALOR, VALOR1, VALOR2, VALOR3, VALOR4, VALOR5,  VALOR7, VALOR8, VALOR9, VALOR10, VALOR11, VALOR12, VALOR13;
        N = int.Parse(Console.ReadLine());
        VALOR =N % 100 ;
        VALOR1 = VALOR % 50;
        VALOR2 = VALOR1 % 20;
        VALOR3 = VALOR2 % 10;
        VALOR4 = VALOR3 % 5;
        VALOR5 = VALOR4 % 2;
        VALOR7 = N / 100;
        VALOR8 = VALOR / 50;
        VALOR9 = VALOR1 / 20;
        VALOR10 = VALOR2 / 10;
        VALOR11 = VALOR3 / 5;
        VALOR12 = VALOR4 / 2;
        VALOR13 = VALOR5 / 1;
        Console.WriteLine(N);
        Console.WriteLine(VALOR7 + " nota(s) de R$ 100,00");
        Console.WriteLine(VALOR8 + " nota(s) de R$ 50,00");
        Console.WriteLine(VALOR9 + " nota(s) de R$ 20,00");
        Console.WriteLine(VALOR10 + " nota(s) de R$ 10,00");
        Console.WriteLine(VALOR11 + " nota(s) de R$ 5,00");
        Console.WriteLine(VALOR12 + " nota(s) de R$ 2,00");
        Console.WriteLine(VALOR13 + " nota(s) de R$ 1,00");
        
    }

}