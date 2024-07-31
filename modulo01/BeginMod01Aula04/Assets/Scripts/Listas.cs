using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> intLista = new List<int>();
        PreencherListaAutomatic(intLista, 5);
        ImprimirLista(intLista);

        List<string> frutasLista = new List<string>(new string[] {"maçã", "uva", "manga"});
        ImprimirLista(frutasLista);

        //imprimindo ordenado
        intLista.Sort();
        ImprimirLista(intLista);
    }

    private void ImprimirLista(List<int> lista)
    {
        string str = "Lista:\n";
        for(int i = 0; i < lista.Count; i++)
        {
            str += $"{lista[i].ToString()}, ";
        }
        Debug.Log(str);
    }

    private void ImprimirLista(List<string> lista)
    {
		string str = "Lista:\n";
		for (int i = 0; i < lista.Count; i++)
		{
			str += $"{lista[i]}, ";
		}
		Debug.Log(str);
	}

    private void PreencherListaAutomatic(List<int> lista,int limite)
    {
        for(int i = 0; i < limite; i++)
        {
            lista.Add(Random.Range(0,limite));
        }
    }
    
}
