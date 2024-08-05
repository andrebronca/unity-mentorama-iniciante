using System.Collections.Generic;
using UnityEngine;

public class ProgramMod8_2 : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Animal mamifero = new Mamifero();
		Animal cat = new Cat();
		Animal dog = new Dog();

		mamifero.AnimalSound();
		cat.AnimalSound();
		dog.AnimalSound();

		List<Animal> animals = new List<Animal>();
		animals.Add(mamifero);
		animals.Add(cat);
		animals.Add(dog);

		foreach (var a in animals)
		{
			a.AnimalSound();
		}
	}
}

internal abstract class Animal
{

	public abstract void AnimalSound();

	public void Sleep()
	{
		Debug.Log("zzzzzzz");
	}
}

internal class Mamifero : Animal
{

	//virtual: o método pode ser sobrescrito
	//tem que usar, override nas classes filhas
	//de métodos herdados sobrescritos

	//	public virtual void AnimalSound()
	//	{
	//		Debug.Log($"zzz");
	//	}

	public override void AnimalSound()
	{
		throw new System.NotImplementedException();

	}
}

class Cat : Animal
{
	public override void AnimalSound()
	{
		Debug.Log("Miau");
	}
}

internal class Dog : Animal
{
	public override void AnimalSound() => Debug.Log($"Au");
}
