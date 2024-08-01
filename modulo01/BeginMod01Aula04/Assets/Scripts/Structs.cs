using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs : MonoBehaviour
{
    [Serializable]  //para aparecer no Unity
    struct PlayerData
    {
        public int Health;
        public int Score;
        public string Name;
        public int[] Status;
        public Coordinates Coordinates;
		public PlayerState PlayerState;
    }

    [Serializable]
    struct Coordinates
    {
        public int x;
		public int y;
    }

    [Serializable]
	enum PlayerState
    {
        Alive,
        Dead
    }

    [SerializeField]
	PlayerData playerData = default;
    [SerializeField]
    PlayerData[] playerDatasList = default;

	// Start is called before the first frame update
	void Start()
    {
        playerData = new PlayerData
        {
            Name =  "Unity",
            Coordinates = new Coordinates { x = 1, y = 3 },
            PlayerState = PlayerState.Alive,
            Status = new int[] {55,66,77},
        };

        Debug.Log(playerData.ToString());
        

    }

}
