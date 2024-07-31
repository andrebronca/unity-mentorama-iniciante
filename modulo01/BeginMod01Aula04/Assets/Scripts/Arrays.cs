using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
	[SerializeField] string[] listaFrutas = null;
    [SerializeField] int tamanhoArray;

	// Start is called before the first frame update
	void Start()
    {
        int[] intArray = new int[5];
        int[] initArray = new int[] { 1, 2, 3, 4 };

        int[,] intMatrix = new int[3, 3]; //linha,coluna
        int[,] matrix = new int[,] { {1, 2, 3},{4, 5, 6} };
        
        //matriz identidade
        intMatrix[0, 0] = 1;
        intMatrix[1, 1] = 1;
        intMatrix[2, 2] = 1;

		//último elemento
		int ultimo = initArray[initArray.Length - 1];

        listaFrutas = new string[] { "laranja", "maçã", "banana", "uva", "pêra", "manga" };

        ImprimirArray(listaFrutas);
        ImprimirArray(initArray);

        int[] arrTemp = arrayAleatorio(tamanhoArray);
        Debug.Log($"Menor valor: {menorValor(arrTemp)}");
        ImprimirArray(arrTemp, true);
        OrdenarCrescenteArray(arrTemp);
        OrdenarDecrescenteArray(arrTemp);

	}

    private void ImprimirArray(int[] arr, bool linha = false)
    {
        string str = "";
        for(int i = 0; i < arr.Length; i++)
        {
            if ( linha)
            {
                str += arr[i] + ",";
            } 
            else
            {
                Debug.Log(arr[i]);
            }
        }
        if (linha)
        {
            Debug.Log($"Array:\n{str}");
        }
    }

    /// <summary>
    /// Tem que fazer uma cópia para não alterar o array
    /// original.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="crescente"></param>
    private void OrdenarCrescenteArray(int[] arr)
    {
        int trocar = arr[0];
        int[] arrTmp = copiarArray(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (arrTmp[i] > arrTmp[j])
                {
                    trocar = arrTmp[j];
                    arrTmp[j] = arrTmp[i];
                    arrTmp[i] = trocar;
                }
            }
        }
        ImprimirArray(arrTmp, true);
    }

	private void OrdenarDecrescenteArray(int[] arr)
	{
		int trocar = arr[arr.Length - 1];
		int[] arrTmp = copiarArray(arr);

		for (int i = arr.Length - 1; i >= 0; i--)
		{
			for (int j = i - 1; j >= 0; j--)
			{
				if (arrTmp[i] > arrTmp[j])
				{
					trocar = arrTmp[i];
					arrTmp[i] = arrTmp[j];
					arrTmp[j] = trocar;
				}
			}
		}
		ImprimirArray(arrTmp, true);
	}

	private int[] copiarArray(int[] arr)
    {
        int[] tmp = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            tmp[i] = arr[i];
        }
        return tmp;
    }

    private void ImprimirArray(string[] arr
        , bool linha = false)
    {
        for (int i = 0;i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }

    private int menorValor(int[] arr)
    {
        int max = int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    private int[] arrayAleatorio(int tamanho) //, int espera_milis)
    {
        int[] arr = new int[tamanho];  

        for(int i = 0; i < tamanho ; i++)
        {
            arr[i] = Random.Range(0, tamanho);
            //System.Threading.Thread.Sleep(espera_milis);
            //espera_milis -= Random.Range(1, espera_milis);
        }
        return arr;
    }

}
