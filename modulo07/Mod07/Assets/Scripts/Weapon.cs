using UnityEngine;

public class Weapon
{
	public int Damage { get; set; }
	public int Rank { get; set; }


	//deixar como public, senão não consegue instanciar
	public Weapon()
	{
		Debug.Log("construtor vazio");
		Damage = 10;
		Rank = 'A';
	}

	public Weapon(int damage, char rank)
	{
		Damage = damage;
		Rank = rank;
	}


	int attack()
	{
		Debug.Log($"Atacando com {Damage} de dano.");
		return Damage;
	}
}