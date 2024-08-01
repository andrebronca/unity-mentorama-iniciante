using UnityEngine;

public class Program : MonoBehaviour
{
	Weapon Weapon;

	void Start()
	{
		Weapon = new Weapon();
		Weapon.Damage = -10;
		Debug.Log($"Valor do estrago: {Weapon.Damage}");
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Weapon = null;
			System.GC.Collect();    //chama o Garbage Collector
		}
	}
}
