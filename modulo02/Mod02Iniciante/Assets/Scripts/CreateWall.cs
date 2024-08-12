using UnityEngine;

public class CreateWall : MonoBehaviour
{
	public GameObject plane;  //plano

	//monta a parede esquerda
	public GameObject wallPrefabLeft;   //parede esquerda
	private float wallWidth;    //eixo x. lado esquerdo do plane
	private float planeWidth;   //largura do plane
	private int cloneWallCount = 0;

	//monta a parede de fundo
	public GameObject wallPrefabBackground;
	private float wallHeight;   //altura da parede
	private float planeHeight;  //altura do plano
	private float planeDepth;   //profundidade do plano
	private int fundoCount = 0;

	void Start()
	{
		//faz a parede esquerda
		planeWidth = plane.transform.localScale.x * 10f; //10f é padrão
		wallWidth = wallPrefabLeft.transform.localScale.x;

		//faz a parede de fundo
		planeDepth = plane.transform.localScale.z * 10f;
	}

	void Update()
	{
		CheckKeyPressed();
	}

	private void CheckKeyPressed()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			float a = planeWidth / 2f;
			float b = wallWidth / 2f;
			float c = cloneWallCount * wallWidth;
			float nextCubeX = plane.transform.position.x + a - b - c;
			CheckAndCreateWall(nextCubeX);
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			CreateWallBackground();
		}
	}

	private void CheckAndCreateWall(float nextWallX)
	{
		float a = wallWidth / 2f;
		float b = planeWidth / 2f;

		//verfica se o próximo wall ainda está na borda do plane
		if (nextWallX - a >= plane.transform.position.x - b)
		{
			float y = wallPrefabLeft.transform.position.y;
			float z = wallPrefabLeft.transform.position.z;

			//clonar e posicionar corretamente
			Vector3 newPosition = new Vector3(nextWallX, y, z);
			GameObject newWall = Instantiate(wallPrefabLeft, newPosition, Quaternion.identity);
			cloneWallCount++;
		}
		else
		{
			Debug.Log("Parede esquerda concluída, não é possível adicionar mais parede.");
		}
	}

	private void CreateWallBackground()
	{
		//posição inicial da parede
		float startX = wallPrefabBackground.transform.position.x;
		float startY = wallPrefabBackground.transform.position.y;
		float nextZ = -planeDepth / 2f + wallWidth / 2f + fundoCount * wallWidth;

		if (nextZ <= planeDepth / 2f)
		{
			Vector3 newPosition = new Vector3(startX, startY, nextZ);
			GameObject newFundo = Instantiate(wallPrefabBackground,
				newPosition, wallPrefabBackground.transform.rotation);
			fundoCount++;
		}
		else
		{
			Debug.Log("Não é possível adicionar parede de fundo, limite atingido");
		}
	}
}
