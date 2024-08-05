using UnityEngine;

public class Combat : MonoBehaviour
{
	private Character _player1;
	private Character _player2;

	void Start()
	{
		var sword = new Sword(8); //espada
		_player1 = new Character("Lex", 100, sword);

		var dagger = new Dagger(0.1f); //punhal
		_player2 = new Character("Ana", 90, dagger);

		Debug.Log($"Carregando configurações");
	}

	void Update()
	{
		PlayerKeys();
	}

	private void PlayerKeys()
	{
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
			_player1.EquipWeapon(GetRandomWeapon());
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
			_player2.EquipWeapon(GetRandomWeapon());
		}
	}

	private Weapon GetRandomWeapon()
	{
		var randomWeapon = Random.Range(0, 2);
		switch (randomWeapon)
		{
			default:
			case 0:
				return new Sword();
			case 1:
				return new Dagger(0.1f);
		}
	}
}
