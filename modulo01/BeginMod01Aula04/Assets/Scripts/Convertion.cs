using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convertion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* Exemplos com cast explícito
         */

        bool b = Convert.ToBoolean(1);

        float n1 = Convert.ToSingle("4");
        n1 = float.Parse("5");
        float n2 = Convert.ToSingle("0,056");
        Debug.Log($"a) Número convertido: {n1:#.00}");
        Debug.Log($"b) Número convertido: {n2:0.000}");
    }
}
