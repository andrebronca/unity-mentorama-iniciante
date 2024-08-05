using UnityEngine;

public class Character
{
	public string Name { get; private set; }
	public int Life { get; private set; }
	public Weapon Weapon { get; private set; }

	public bool IsAlive { get => Life > 0; }

	public bool WeaponNotNull { get => Weapon != null; }

	public Character(string name, int life, Weapon weapon)
	{
		Name = name;
		Life = life;
		Weapon = weapon;
	}

	public void Attach(Character other)
	{
		if (IsAlive && WeaponNotNull)  //estar vivo e com arma para atacar
		{
			Debug.Log($"{Name} atacou {other.Name} com {Weapon.Name}");
			other.DealDamage(Weapon.Swing(), other);
		}
		if (!IsAlive)
		{
			Debug.Log($"{Name} morreu, não pode mais atacar!");
		}
		if (!WeaponNotNull)
		{
			Debug.Log($"{Name} sem arma, não pode atacar!");
		}
	}

	private void DealDamage(int amount, Character other)
	{
		if (IsAlive && WeaponNotNull)
		{
			other.Life -= amount;
			other.Life = other.Life < 0 ? 0 : other.Life;
			Debug.Log($"{other.Name} sofreu {amount} de dano.\n" +
				$"Oponente: {other.Name} possui vida: {other.Life}");
		}

		if (other.Life == 0)
		{
			GameOver(other);
		}

	}

	private void GameOver(Character player)
	{
		Debug.Log($"Oponente eliminado: {player.Name} - Game Over");
		player.Weapon = null;   //se morreu perde a arma
	}

	//afiar lâmina
	public void SharpenWeapon()
	{
		if (IsAlive && WeaponNotNull) //estar vivo e ter arma para afiar
		{
			Debug.Log($"{Name} afiou sua {Weapon.Name}");
			Weapon.Sharpen();
		}
		if (!IsAlive)
		{
			Debug.Log($"Oponente já foi eliminado: {Name}"); //se morreu, não afia nada
			return;
		}
		if (!WeaponNotNull)
		{
			Debug.Log($"{Name} está sem arma para afiar."); //sem arma não afia
			return;
		}

	}

	//ficar sem arma
	public void UnequipWeapon()
	{
		if (!IsAlive)   //se está morto já está sem arma
		{
			return;
		}
		if (WeaponNotNull)
		{
			Debug.Log($"{Name} desequipou sua {Weapon.Name}");
			Weapon = null;
		}
	}

	//obter uma arma
	public void EquipWeapon(Weapon weapon)
	{
		if (!IsAlive)   //morto não possui arma
		{
			return;
		}
		if (!WeaponNotNull) //só aceita uma nova arma se estiver sem
		{
			Weapon = weapon;
			Debug.Log($"{Name} equipado com:\n" +
				$"Name {Weapon.Name}\n" +
				$"Dano: {Weapon.Damage}\n" +
				$"Rank: {Weapon.Rank}");
		}
	}
}