using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        int b = 0;
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(++a);
        Debug.Log(b++);

        /* exemplos com float e string
         */

        bool res = true;
        Debug.Log(res);
        Debug.Log(!res);
        Debug.Log(true & false);
        Debug.Log(true | true);
        Debug.Log(true ^ true);
        Debug.Log(true && true);
        Debug.Log(false || true);

        //precedência do primeiro ao último: !, &, ^, |, &&, ||

        /* exemplos com operadores relacionais
         */
        
    }
}
