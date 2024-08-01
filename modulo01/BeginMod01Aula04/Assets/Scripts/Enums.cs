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
    }

    
}
