using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //sempre que for trabalhar com gerenciamento de cena


public class Script05SceneManager : MonoBehaviour
{
    void LoadScene()
    {
        //vai carregar a cena que tem o nome: Scene01. Não deve ter cenas com nomes repetidos.
        SceneManager.LoadScene("Scene01");
        //carrega a cena conforme o index.
        //File > Build Settings. arrastar a cena do Project para Scenes in Build, irá mostrar o index da cena.
        SceneManager.LoadScene(1);
        //Unity carrega a cena enquanto reliza outras tarefas.
        SceneManager.LoadSceneAsync(1);
        //Se tiver duas cenas, passando da 1 para a 2, irá remover a 1 e já mostrar a 2.
        SceneManager.LoadScene("Scene01", LoadSceneMode.Single);
        //Não remove uma das cenas e carrega a próxima. Permite carregar e descarregar cenas para liberar memória.
        //exemplo: Game Celeste
        SceneManager.LoadScene("Scene01", LoadSceneMode.Additive);
    }
    
    public void LoadSceneWithParameterStr(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneWithParameterInt(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
