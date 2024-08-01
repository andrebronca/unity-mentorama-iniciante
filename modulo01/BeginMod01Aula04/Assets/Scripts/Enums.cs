using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
	enum GameState
	{
		Starting,
		InGame,
		GameOver
	}

	[SerializeField]
	GameState gameState;    //variável do tipo enum

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Starting;

		if (gameState == GameState.Starting)
		{
			Debug.Log($"{gameState} = {(int)gameState}");
		}

		LogStatus(gameState);
    }

	private void LogStatus(GameState gs)
	{
		switch (gs)
		{
			case GameState.Starting:
				Debug.Log($"Iniciando o jogo");
				break;
			case GameState.GameOver:
				Debug.Log($"Finalizando o Jogo");
				break;
			case GameState.InGame:
				Debug.Log($"Executando o Jogo");
				break;
		}
	}

    
}
