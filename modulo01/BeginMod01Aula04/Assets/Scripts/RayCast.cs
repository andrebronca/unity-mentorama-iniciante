using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    /* bitshift operation: forma de definir qual será a layer acertada para o RayCast.
     * Nesse caso é a layer 8 que define se o RayCast acertou.
     */
    int layerMask = 1 << 8;

    private void FixedUpdate()
    {
        //RayCastSimples();
        RayCastEmLayer();
    }

    private void RayCastEmLayer()
    {
        RaycastHit hit;
        /* position: local de onde sai o raio em que o script está vinculado
         * TransformDirection: direção para onde está sendo lançado o raio
         * hit: tudo o que for acertado será esse parâmetro
         * Infinity: duração desse raio
         */
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity, layerMask))
        {
            Debug.Log("Acertou: " + hit.collider.name);
        }
        else
        {
            //Debug.Log("Errou");
        }
    }

    private void RayCastSimples()
    {
        RaycastHit hit;
        /* position: local de onde sai o raio em que o script está vinculado
         * TransformDirection: direção para onde está sendo lançado o raio
         * hit: tudo o que for acertado será esse parâmetro
         * Infinity: duração desse raio
         */
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity))
        {
            Debug.Log("Acertou: " + hit.collider.name);
        }
        else
        {
            //Debug.Log("Errou");
        }
    }
}
