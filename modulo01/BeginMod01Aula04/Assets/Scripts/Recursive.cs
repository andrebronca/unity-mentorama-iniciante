using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Recursive : MonoBehaviour
{
    [SerializeField] private int fatorar1;
	[SerializeField] private int fatorar2;
    [SerializeField] private int ehPrimo;
    [SerializeField] private int ehPrimo2;
    [SerializeField] private int acharPrimosAte;
    

	// Start is called before the first frame update
	void Start()
    {
        BigInteger fat = Fatorial(fatorar1);
        Debug.Log($"Com recursividade: {fatorar1}! = {fat}");

        fat = FatorialComWhile(fatorar2);
		Debug.Log($"Com while: {fatorar2}! = {fat}");

        //FizzBuzz(fatorar2);
        FizzBuzz2(fatorar2);

        DivisorsOfNumber(ehPrimo);
        DivisorsOfNumber(ehPrimo2);
        //FindPrimeNumbers(acharPrimosAte);
        SearchMaxPrimeTo(acharPrimosAte);
        Debug.Log($"É nr primo: {IsPrimeNumber(ehPrimo2)}");
	}

    //com recursividade
    private int Fatorial(int valor)
    {
        //if (valor == 0)
        //{
        //    return 1;
        //}
        //else
        //{
        //    return valor * Fatorial(valor - 1);
        //}
        return valor > 0 ? valor * Fatorial(--valor) : 1;
	}

	//com repetição
	//limite sem overflow: 30! = 1_409_286_144
	private BigInteger FatorialComWhile(int valor)
    {
        int result = valor;

        while (valor > 1)
        {
            result *= --valor;
            //result *= valor - 1;
            //valor--;
        }
        return result;
    }

    private void FizzBuzz(int valor)
    {
        for(int i = 1; i <= valor; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log($"(3,5) FizzBuzz: {i}");
            }
            else if (i % 3 == 0)
            {
				Debug.Log($"(3) Fizz: {i}");
			}
            else if (i % 5 == 0)
            {
				Debug.Log($"(5) Buzz: {i}");
			}
            else
            {
				//Debug.Log($"...: {i}");
			}
        }
    }

    private void FizzBuzz2(int valor)
    {
        string msg = "";
        for (int i = 1; i <= valor; i++)
        {
            msg += i % 3 == 0 && i % 5 == 0 ? 
                $"FizzBuzz {i}" :
				i % 3 == 0 ? $"Fizz {i}" :
				i % 5 == 0 ? $"Buzz {i}" : "";

            if (msg.Length > 0)
            {
                Debug.Log(msg);
                msg = "";
            }
        }
    }

    private void DivisorsOfNumber(int number)
    {
        if (number > 1)
        {
            int count_divisores = 0;
            string status;
            string C_SEP = ", ";
            string C_INI = "{";
            string C_END = "}";
            string divisores = "" ;

			for (int i = 1; i <= number; i++)
			{
                if (number % i == 0)
                {
                    count_divisores++;
                    divisores += i + C_SEP;
                }
			}
            if (count_divisores == 2)
            {
                status = $"primo: {number}, possui {count_divisores}.";
			} 
            else
            {
				status = $"não é primo: {number}, possui {count_divisores}.";
			}
			divisores = MountList(C_INI, divisores, C_SEP, C_END);
			Debug.Log($"{status}, divisores: {divisores}");
		}
    }

    private string MountList(string ini, string s, string sep, string end)
    {
        return ini
            + s.Substring(0, s.Length - sep.Length)
            + end;
    }

    /// <summary>
    /// Até determinado número lista os números primos.
    /// Essa consulta trava se tiver números grandes.
    /// limites: Unity: 22k, online: 278k
    /// </summary>
    /// <param name="until"></param>
    private void FindPrimeNumbers(int until)
    {
        if (until > 1)
        {
            string primes = "";
            for(int i = 2; i <= until; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count > 2) //otimização
                    {
                        break;
                    }
                }
                if (count == 2)
                {
                    primes += i + ", ";
                }
            }
            Debug.Log($"Até {until}, primos: {primes}");
        }
    }

    /// <summary>
    /// Em um intervalor, lista os números primos.
    /// Se o intervalo for muito grande, pode travar.
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
	private void SearchFromTo(int from, int to)
	{
		if (to > 1)
		{
			string primes = "";
			for (int i = from; i <= to; i++)
			{
				int count = 0;
				for (int j = 1; j <= i; j++)
				{
					if (i % j == 0)
					{
						count++;
					}
					if (count > 2) //otimização
					{
						break;
					}
				}
				if (count == 2)
				{
					primes += i + ", ";
				}
			}
			Debug.Log($"De {from} até {to}, primos: {primes}");
			//Console.WriteLine ($"Until {until}, \nlist of primes: {primes}");
		}
	}


    /// <summary>
    /// informando um número, irá exibir o maior número primo
    /// </summary>
    /// <param name="number"></param>
    private void SearchMaxPrimeTo(int number)
    {
		if (number > 1)
		{
			int prime = 0;
			int count = 0;
			for (int i = number; i > 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					if (i % j == 0)
					{
						count++;
					}
					if (count > 2)
					{ //se tem mais de dois divisores, não é primo
						break;
					}
				}
				if (count == 2)
				{ //entende-se que é primo
					prime = i;
					break;  //para no maior número primo encontrado
				}
				count = 0;
			}
			Debug.Log($"Maior primo ate {number} eh {prime}");
			//Console.WriteLine($"Maior primo ate {number} eh {prime}");
		}
	}

    /// <summary>
    /// Testar se um número é primo
    /// </summary>
    /// <param name="number"></param>
    private bool IsPrimeNumber(int number)
    {
        if (number > 1)
        {
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            return count == 2;
        }
        return false;
    }
}
