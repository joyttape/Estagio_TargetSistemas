using System;

class Program
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("QUESTÕES - Estágio Ribeirão Preto ");
        Console.WriteLine(" 1 - Questão 01");
        Console.WriteLine(" 2 - Questão 02");
        Console.WriteLine(" 3 - Questão 03");
        Console.Write("Escolha uma questão: ");

        int ex = Convert.ToInt32(Console.ReadLine());

        switch (ex)
        {
            case 1:
                Questao1();
                break;

            case 2:
                Questao2();
                break;

            case 3:
                Questao3();
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static void Questao1()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool pertence = PertenceSequenciaFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

        Console.WriteLine("");
        Console.WriteLine("Voltar para o menu? 1 - SIM 0 - NÃO");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.Clear();
            Menu();
        }
        else
        {
            Console.Clear();
            Questao1();

        }
    }

    static void Questao2()
    {
        Console.Write("Digite uma palavra: ");
        string p = Console.ReadLine();


        int contador = ContarOcorrenciasDeA(p);

        if (contador > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {contador} vez/vezes na string informada.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string informada.");
        }

        Console.WriteLine("Voltar para o menu? 1 - SIM 0 - NÃO");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.Clear();
            Menu();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("");
            Questao2();

        }
        Menu();
    }

    static void Questao3()
    {
        int INDICE = 12, SOMA = 0, K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"O valor da soma é: {SOMA}");

        Console.WriteLine("Voltar para o menu? 1 - SIM 0 - NÃO");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.Clear();
            Menu();
        }
        else
        {
            Console.Clear();
            Questao3();

        }
    }

    static bool PertenceSequenciaFibonacci(int numero)
    {
        int a = 0, b = 1, fibonacci = 0;

        if (numero == 0 || numero == 1) return true;

        while (fibonacci < numero)
        {
            fibonacci = a + b;
            a = b;
            b = fibonacci;

            if (fibonacci == numero)
            {
                return true;
            }
        }

        return false;
    }

    static int ContarOcorrenciasDeA(string texto)
    {
        int contador = 0;
        string textoMaiusculo = texto.ToUpper();

        foreach (char c in textoMaiusculo)
        {
            if (c == 'A' || c == 'À' || c == 'Á')
            {
                contador++;
            }
        }

        return contador;
    }
}



