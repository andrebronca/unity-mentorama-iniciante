using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class IfElse : MonoBehaviour
{
    [SerializeField]
    private float nota_1;
    [SerializeField]
    private float nota_2;
    private float media;



    // Start is called before the first frame update
    void Start()
    {
        //TesteIf();
        CalculaMedia();   
    }

    private void CalculaMedia()
    {
        media = (nota_1 + nota_2) / 2f;
        if (media >= Constantes.NOTA_MEDIA)
        {
            Debug.Log(Constantes.APROVA);
        }
        else if (media >= Constantes.NOTA_MINIM)
        {
            Debug.Log(Constantes.RECUPE);
        }
        else
        {
            Debug.Log(Constantes.REPROV);
        }
    }

    private void TesteIf()
    {
        bool choveu_hoje = true;
        if (choveu_hoje)
        {
            Debug.Log("Usar guarda-chuva");
        }
        else
        {
            Debug.Log("tempo seco");
        }

        int milimetros_chuva = 100;
        if (choveu_hoje & milimetros_chuva > 90)
        {
            Debug.Log("Risco de alagamento");
        }
        else if (choveu_hoje & milimetros_chuva < 20)
        {
            Debug.Log("O suficiente para molhar");
        }
        else
        {
            Debug.Log("As plantas agradecem");
        }
    }

}

static class Constantes
{
    public const float NOTA_MEDIA = 6.0f;
    public const float NOTA_MINIM = 4.0f;
    public const string APROVA = "Aprovado";
    public const string REPROV = "Reprovado";
    public const string RECUPE = "Recuperação";
}
