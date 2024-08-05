using UnityEngine;

public class Weapon_bkp
{
	private int _damage;
	private char rank;


	//definindo uma property
	public int estrago
	{
		//get
		//{
		//	return _damage;
		//}
		get => _damage;

		//internal set    //pode ser private tamb�m
		//{
		//	if (value < 0)
		//	{
		//		_damage = 0;
		//	}
		//	else
		//	{
		//		_damage = value;
		//	}
		//}

		set => _damage = value; //ou dessa forma
	}

	////property mais simplificada
	//public int Cartucho { get; set; }
	//public bool Travar { get; set; }
	//public bool Guardar { get; private set; }

	//n�o � permitido criar array como constante
	//array � um objeto
	//public const char[] nivel = new char[] { 'A', 'B', 'C' };
	//lembrando que deve ser alterado em constructor
	//public readonly char[] nivel = new char[] { 'a', 'b', 'c' };

	////Testando encapsulamento
	//public int a;       //vis�vel na inst�ncia
	//private int b;
	//protected int c;
	//internal int d;     //vis�vel na inst�ncia

	//protected internal int e;   //vis�vel na inst�ncia
	//private protected int f;

	////sugest�o de padr�o (estranho)
	//public int A;   //public inicia em ma�usculo
	//private int _b; //private inicia com _
	//				//par�metros de m�todos iniciam com min�scula
	//				//vari�veis internas de m�todos iniciam com min�scula

	//private const float _pi = 3.1415f;  //const � obrigat�rio atribuir valor na declara��o
	//private readonly int _myReadOnly;   //s� pode ser alterado no construtor

	//deixar como public, sen�o n�o consegue instanciar
	public Weapon_bkp()
	{
		Debug.Log("construtor vazio");
		_damage = 10;
		rank = 'S';
	}

	//defindo um destructor da classe
	//quando o objeto se tornar null, ir� executar o destructor
	//n�o precisa ser p�blico, n�o deve ter par�metros,
	//tem o ~ antes do nome
	~Weapon_bkp()
	{
		Debug.Log("Executando o destructor");
	}

	public Weapon_bkp(int damage, char rank)
	{
		estrago = damage;
		this.rank = rank;
	}

	//constructor com arrow function
	public Weapon_bkp(int damage) => estrago = damage;

	int attack()
	{
		Debug.Log($"Atacando com {estrago} de dano.");
		return estrago;
	}
}