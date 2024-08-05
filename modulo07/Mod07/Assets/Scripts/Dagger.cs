
using UnityEngine;

public class Dagger : Weapon
{
	public float CritChance { get; private set; } // = 1; pode ser atribuído valor inicial

	private const string NAME = "Dagger";

	//permitindo a customização
	public Dagger(int damage, float critChance) : base(NAME, damage)
	{
		CritChance = critChance;
	}

	//passando valores padrões
	public Dagger(float critChance) : base(NAME, 6)
	{
		CritChance = critChance;
	}

	public override int Swing()
	{
		Debug.Log($"Fura...");

		var finalDamage = Damage;
		if (Random.Range(0f, 1f) < CritChance)
		{
			Debug.Log("Critical hit!");
			finalDamage *= 2;
		}

		return finalDamage;
	}
}
