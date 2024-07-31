using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Colidir : MonoBehaviour
{
    //Os dois objetos tem que ter Collider para detectar essa colisão
    //E ao menos um dos objetos tem que ter um Rigidbody
    //other: é o que colidiu com o objeto que esse script está vinculado
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER DE COLISÃO: "+ other.name);
    }

    //essa função só funciona com o Is Trigger desmarcado
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLISÃO: "+ collision.rigidbody.name);
    }

}
