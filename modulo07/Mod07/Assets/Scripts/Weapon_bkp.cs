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

		//internal set    //pode ser private também
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

	//não é permitido criar array como constante
	//array é um objeto
	//public const char[] nivel = new char[] { 'A', 'B', 'C' };
	//lembrando que deve ser alterado em constructor
	//public readonly char[] nivel = new char[] { 'a', 'b', 'c' };

	////Testando encapsulamento
	//public int a;       //visível na instância
	//private int b;
	//protected int c;
	//internal int d;     //visível na instância

	//protected internal int e;   //visível na instância
	//private protected int f;

	////sugestão de padrão (estranho)
	//public int A;   //public inicia em maíusculo
	//private int _b; //private inicia com _
	//				//parâmetros de métodos iniciam com minúscula
	//				//variáveis internas de métodos iniciam com minúscula

	//private const float _pi = 3.1415f;  //const é obrigatório atribuir valor na declaração
	//private readonly int _myReadOnly;   //só pode ser alterado no construtor

	//deixar como public, senão não consegue instanciar
	public Weapon_bkp()
	{
		Debug.Log("construtor vazio");
		_damage = 10;
		rank = 'S';
	}

	//defindo um destructor da classe
	//quando o objeto se tornar null, irá executar o destructor
	//não precisa ser público, não deve ter parâmetros,
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