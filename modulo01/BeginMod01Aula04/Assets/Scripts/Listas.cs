using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
	//matriz com list
	[SerializeField]
	private List<List<int>> matrizList;


	// Start is called before the first frame update
	void Start()
	{
		matrizList = new List<List<int>>();

		List<int> intLista = new List<int>();
		PreencherListaAutomatic(intLista, 5);
		ImprimirLista(intLista);

		List<string> frutasLista = new List<string>(new string[] { "maçã", "uva", "manga" });
		ImprimirLista(frutasLista);

		//imprimindo ordenado
		intLista.Sort();
		intLista.Clear();
		intLista.AddRange(new int[] { 11, 22, 33 });
		ImprimirLista(intLista);

		matrizList.Add(new List<int>(new int[] {40,50,60}));
		matrizList.Add(new List<int>(new int[] {44,55,66}));
		matrizList.Add(new List<int>(new int[] {440,550,660}));
		ImprimirLista(matrizList[0]);
		List<int> listMeio = matrizList[1];
		int[] arrayMeio = matrizList[1].ToArray() ;
	}

	public void ImprimirLista(List<int> lista)
	{
		string str = "Lista:\n";
		for (int i = 0; i < lista.Count; i++)
		{
			str += $"{lista[i].ToString()}, ";
		}
		Debug.Log(str);
	}

	public void ImprimirLista(List<string> lista)
	{
		string str = "Lista:\n";
		for (int i = 0; i < lista.Count; i++)
		{
			str += $"{lista[i]}, ";
		}
		Debug.Log(str);
	}

	public void ImprimirLista(string[] arr)
	{
		ImprimirLista(new List<string>(arr));
	}
	
	public void ImprimirLista(int[] arr)
	{
		ImprimirLista(new List<int>(arr));
	}

	private void PreencherListaAutomatic(List<int> lista, int limite)
	{
		for (int i = 0; i < limite; i++)
		{
			lista.Add(Random.Range(0, limite));
		}
	}

}
