
using UnityEngine;

public class Sword : Weapon
{
	private const string NAME = "Sword";

	public Sword() : base(NAME, 8) { }

	public Sword(int damage) : base(NAME, damage) { }

	public override int Swing()
	{
		Debug.Log($"Cortar...");
		return Damage;
	}

	public override void Sharpen()
	{
		Damage++;
		base.Sharpen();
	}
}