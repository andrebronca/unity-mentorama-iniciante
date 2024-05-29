using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentaCubo : MonoBehaviour
{
    //permite que no componente apareça esse atributo para edição
    [SerializeField] float speed = 0.5F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EventListenerMovimentacaoPorSetas();
        EventTeclaPressionada();
        EventTeclaLiberada();
        EventClicMouse();
    }

    void EventListenerMovimentacaoPorSetas()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //o objeto que o script está vinculado possui uma posição
            //Time.deltaTime: é o tempo de execução entre um frame e outro.
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }

    //Criando um efeito de pulo
    void EventTeclaPressionada()
    {
        //só executa após o botão ser pressionado
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * (speed * 100) * Time.deltaTime;
        }
    }

    //fazendo um efeito para
    void EventTeclaLiberada()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position += Vector3.down * (speed * 100) * Time.deltaTime;
        }
    }

    void EventClicMouse()
    {
        //0: esquerdo, 1: direito, 2: scroll
        if (Input.GetMouseButton(0))
        {
            //reiniciando a cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
