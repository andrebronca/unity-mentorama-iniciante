using UnityEngine;

public class Weapon_bkp2
{
	public int Damage { get; set; }
	public int Rank { get; set; }


	//deixar como public, senão não consegue instanciar
	public Weapon_bkp2()
	{
		Debug.Log("construtor vazio");
		Damage = 10;
		Rank = 'A';
	}

	public Weapon_bkp2(int damage, char rank)
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