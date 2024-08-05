
using UnityEngine;

public class Weapon
{
	public string Name { get; private set; }
	public int Damage { get; private set; }
	public char Rank { get; private set; }

	public Weapon(string name, int damage)
	{
		Name = name;
		Damage = damage;
		Rank = GetRank(damage);
	}

	public static char GetRank(int damage)
	{
		if (damage > 10)
		{
			return 'S';
		}
		else if (damage >= 7)
		{
			return 'A';
		}
		else if (damage >= 4)
		{
			return 'B';
		}
		return 'C';
	}

	//afiar lâmina
	public void Sharpen()
	{
		Damage++;
		Debug.Log($"{Name} foi afiada! Dano aumentou para {Damage}");

		VerifyRank(Weapon.GetRank(Damage));
	}

	private void VerifyRank(char rank)
	{
		if (rank != Rank)
		{
			Rank = rank;
			Debug.Log($"Rank da {Name} aumentou para {Rank}");
		}
	}
}