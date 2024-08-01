using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{

    [SerializeField]
    List<string> listFrutas = new List<string>(new string[] { "pera", "uva", "manga"});
    [SerializeField]
    string[] arrayFrutas = new string[] { "maçã", "laranja", "limão" };

    // Start is called before the first frame update
    void Start()
    {
        Listas listas = new Listas();
        listas.ImprimirLista(listFrutas);
        listas.ImprimirLista(arrayFrutas);

        //exemplos com foreach
        ImprimirCada(listFrutas);
        ImprimirCada(arrayFrutas);
        RemoveFindLetter(listFrutas, 'p');
    }
    
    private void ImprimirCada(string[] arr)
    {
        foreach (var item in arr)
        {
            Debug.Log($"Item da lista: {item}");
        }
    }

    private void ImprimirCada(List<string> arr)
    {
        ImprimirCada(arr.ToArray());
    }

    /* Uma outra situação é se vai ignorar diferença
     * de maiúscula/minúscula. Dá para pensar em um parâmetro
     * bool. Ex. se for true, converte para o mesmo case e remove.
     * se for false, só remove se as letras forem iguais.
     */
    private void RemoveFindLetter(List<string> arr, char find)
    {
        string remover = null;
        foreach (var item in arr)   
        {
            if (item[0] == find)
            {
                remover = item; //não é permitido remover aqui dentro
            }
        }
        if (remover != null)
        {
            arr.Remove(remover);
        }
    }
}
