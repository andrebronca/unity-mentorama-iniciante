using UnityEngine;

public class Program : MonoBehaviour
{

	void Start()
	{
		//var sword = new Weapon("Sword", 8); //espada
		//_player1 = new Character("Lex", 100, sword);

		//var dagger = new Weapon("Dagger", 6); //punhal
		//_player2 = new Character("Ana", 90, dagger);

		Debug.Log($"Carregando configurações");
	}

	private Character _player1;
	private Character _player2;

	void Update()
	{
		PlayerKeys();
	}

	private void PlayerKeys()
	{
		if (_player1 == null)
		{
			Debug.Log("[Program.cs] Character Player 1 = null");
			return;
		}

		if (_player2 == null)
		{
			Debug.Log("[Program.cs] Character Player 2 = null");
			return;
		}

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			//Debug.Log($"Player {_player1.Name} atacando!");
			_player1.Attach(_player2);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			//Debug.Log($"Player {_player1.Name} afiar {_player1.Weapon.Name}!");
			_player1.SharpenWeapon();
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			_player1.UnequipWeapon();
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			int rank = Random.Range(0, 9);
			//_player1.EquipWeapon(new Weapon("Faca", rank));
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			//4334Debug.Log($"Player {_player2.Name} atacando!");
			_player2.Attach(_player1);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			//Debug.Log($"Player {_player2.Name} afiar {_player2.Weapon.Name}!");
			_player2.SharpenWeapon();
		}

		if (Input.GetKeyDown(KeyCode.Z))
		{
			_player2.UnequipWeapon();
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			int rank = Random.Range(0, 9);
			//_player2.EquipWeapon(new Weapon("Faca", rank));
		}
	}

}
