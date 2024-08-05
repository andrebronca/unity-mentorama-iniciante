using UnityEngine;

public class ProgramMod8 : MonoBehaviour
{
	void Start()
	{
		var vehicle = new Vehicle();
		vehicle.Honk();
		Debug.Log($"{vehicle.Brand}");
		var car = new Car();
		car.Honk();
		Debug.Log($"{car.Brand} - {car.Model}");

		var truck = new Truck();
		truck.Honk();
		Debug.Log($"{truck.Brand} - {truck.Axels}");
	}

}

internal class Vehicle
{
	public string Brand = "Ford";

	public void Honk()
	{
		Debug.Log($"Foom Foom");
	}
}

internal class Car : Vehicle
{
	public string Model = "Mustang";

	public void StartUp()
	{

	}
}

internal class Truck : Vehicle
{
	public int Axels = 3;
}


//bloqueia a criação de herança
internal sealed class Patinete : Vehicle
{
	public void bip(string msg)
	{
		Debug.Log(msg);
	}
}
