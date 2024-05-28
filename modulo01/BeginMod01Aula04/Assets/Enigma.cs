using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//para visualiar os atributos no inspector
[System.Serializable]
public class Enigma
{
    [SerializeField] public string pergunta;
    [SerializeField] public string respostaCorreta;
    [SerializeField] public string respostaErrada1;
    [SerializeField] public string respostaErrada2;
    [SerializeField] public string respostaErrada3;
}
