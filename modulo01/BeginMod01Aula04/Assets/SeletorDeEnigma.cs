using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //como está usando interface (buttons, text) tem que importar

//aplicação de reinício de sena: botão reiniciar
using UnityEngine.SceneManagement;
using System;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Text pergunta;
    [SerializeField] Text opcaoA;
    [SerializeField] Text opcaoB;
    [SerializeField] Text opcaoC;
    [SerializeField] Text opcaoD;
    [SerializeField] Text pontuacaoText;
    [SerializeField] Text highScoreText;

    List<string> respostas = new List<string>();

    int randomIndice;

    float scoreTotal = 0F;    //será float, pois vou penalizar com 0.25 de desconto para cada clique errado
    const float PONTO_MAXIMO_QUESTAO = 1F;    //pontuação de cada questão, se no primeiro clique for a opção correta
    float scoreHigh = 0F;        //gravar a maior pontuação
    const string HIGH_SCORE_MSG = "High Score: ";   //UI para exibir o maior score
    const string PONTUACAO_MSG = "Pontuação: ";     //UI para exibir a pontuação atual
    const string SCORE_TEMP = "highScoreTemp";

    private void Start()
    {
        //recuperando o score anterior, após reiniciar a cena, caso não tenha valor, atribui zero
        scoreHigh = PlayerPrefs.GetFloat(SCORE_TEMP, 0F);
        highScoreText.text = HIGH_SCORE_MSG + scoreHigh;

        if (lista.listaDeEnigmas.Count > 0)
        {
            int minimoIncluso = 0;
            int maximoExcluso = lista.listaDeEnigmas.Count;
            randomIndice = UnityEngine.Random.Range(minimoIncluso, maximoExcluso);

            //recuperando a composição da questão
            string perguntaSorteada = lista.listaDeEnigmas[randomIndice].pergunta;
            string respostaCorreta = lista.listaDeEnigmas[randomIndice].respostaCorreta;
            string respostaErrada1 = lista.listaDeEnigmas[randomIndice].respostaErrada1;
            string respostaErrada2 = lista.listaDeEnigmas[randomIndice].respostaErrada2;
            string respostaErrada3 = lista.listaDeEnigmas[randomIndice].respostaErrada3;

            //populando a lista sequencialmente
            respostas.Add(respostaCorreta);
            respostas.Add(respostaErrada1);
            respostas.Add(respostaErrada2);
            respostas.Add(respostaErrada3);

            //para fazer a exibição na tela
            pergunta.text = perguntaSorteada;
            opcaoA.text = respostaCorreta;
            opcaoB.text = respostaErrada1;
            opcaoC.text = respostaErrada2;
            opcaoD.text = respostaErrada3;

            // embaralhando
            embaralharOpcoes(opcaoA);
            embaralharOpcoes(opcaoB);
            embaralharOpcoes(opcaoC);
            embaralharOpcoes(opcaoD);

            //usado no debug para mostrar a questão completa - console
            string questao = perguntaSorteada + "\n"
                + respostaCorreta + "\n"
                + respostaErrada1 + "\n"
                + respostaErrada2 + "\n"
                + respostaErrada3 + "\n";

            //Debug.Log("QUESTÃO ALEATÓRIA: "+ questao);
        }
    }

    void embaralharOpcoes(Text obj)
    {
        int posicaoAleatoria = UnityEngine.Random.Range(0, respostas.Count);
        string txt = respostas[posicaoAleatoria];
        obj.text = txt;
        respostas.Remove(txt);
    }

    public void onClickOpcao(Text obj)
    {
        if (lista.listaDeEnigmas.Count > 0)
        {
            bool opcaoCorreta = obj.text == lista.listaDeEnigmas[randomIndice].respostaCorreta;
            scoreTotal += opcaoCorreta ? PONTO_MAXIMO_QUESTAO : 0F;
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[randomIndice]);    //remover a pergunta da lista    
            mudaPlacar();
            Start();    //clicando em qualquer alternativa deve avançar para a próxima questão
        }
    }

    void mudaPlacar()
    {
        if (scoreHigh < scoreTotal)
        {
            scoreHigh = scoreTotal;
        }
        highScoreText.text = HIGH_SCORE_MSG + scoreHigh;
        
        //salvando o valor do highScore caso o jogo seja reiniciado
        PlayerPrefs.SetFloat(SCORE_TEMP, scoreHigh);

        pontuacaoText.text = PONTUACAO_MSG + scoreTotal;
    }

    public void onClickResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   //resetando o estado do jogo
    }

    public void onClickResetHighScore()
    {
        PlayerPrefs.SetFloat(SCORE_TEMP, 0F);
        scoreHigh = PlayerPrefs.GetFloat(SCORE_TEMP, 0F);
        highScoreText.text = HIGH_SCORE_MSG + scoreHigh;
    }
}
