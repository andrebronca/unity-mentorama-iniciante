using UnityEngine;

public class CreateWall : MonoBehaviour
{
	public GameObject plane;    //plano
	private float planeWidth;   //largura do plane

	//monta a parede esquerda
	public GameObject wallLeft;     //parede esquerda
	private float wallWidthLeft;    //eixo x. lado esquerdo do plane
	private int countWallLeft = 0;

	//monta a parede de fundo
	public GameObject wallBack;     //parede de fundo
	private float wallHeightBack;   //altura da parede
	private float planeHeightBack;  //altura do plano
	private float planeDepthBack;   //profundidade do plano
	private int countWallBack = 0;

	//monta a parede direita
	public GameObject wallRight;
	private float wallWidthRight;
	//private float planeWidth;
	private int countWallRight = 0;

	void Start()
	{
		//medida do plane (lado esquerdo/direito)
		planeWidth = plane.transform.localScale.x * 10f; //10f é padrão
														 //medida da parede de fundo
		planeDepthBack = plane.transform.localScale.z * 10f;

		//medida da parede esquerda
		wallWidthLeft = wallLeft.transform.localScale.x;

		//medida da parede direita
		wallWidthRight = wallRight.transform.localScale.x;
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
			float b = wallWidthLeft / 2f;
			float c = countWallLeft * wallWidthLeft;
			float nextCubeX = plane.transform.position.x + a - b - c;
			CreateWallLeft(nextCubeX);
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			CreateWallBack();
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			CreateWallRight();
		}
	}

	private void CreateWallLeft(float nextWallX)
	{
		float a = wallWidthLeft / 2f;
		float b = planeWidth / 2f;

		//verfica se o próximo wall ainda está na borda do plane
		if (nextWallX - a >= plane.transform.position.x - b)
		{
			float y = wallLeft.transform.position.y;
			float z = wallLeft.transform.position.z;

			//clonar e posicionar corretamente
			Vector3 newPosition = new Vector3(nextWallX, y, z);
			GameObject newWall = Instantiate(wallLeft, newPosition, Quaternion.identity);
			countWallLeft++;
		}
		else
		{
			Debug.Log("Parede esquerda concluída, não é possível adicionar mais parede.");
		}
	}

	private void CreateWallRight()
	{
		float z = wallRight.transform.position.z;
		float y = wallRight.transform.position.y;
		float a = planeWidth / 2f;
		float b = wallWidthRight / 2f;
		float c = countWallRight * wallWidthRight;
		float nextWallX = -a + b + c;

		if (nextWallX <= a)
		{
			Vector3 newPosition = new Vector3(nextWallX, y, z);
			GameObject newWall = Instantiate(wallRight, newPosition, Quaternion.identity);
			countWallRight++;
		}
		else
		{
			Debug.Log("Parede direita concluída");
		}
	}

	private void CreateWallBack()
	{
		//posição inicial da parede
		float startX = wallBack.transform.position.x;
		float startY = wallBack.transform.position.y;
		float nextZ = -planeDepthBack / 2f + wallWidthLeft / 2f + countWallBack * wallWidthLeft;

		if (nextZ <= planeDepthBack / 2f)
		{
			Vector3 newPosition = new Vector3(startX, startY, nextZ);
			GameObject newFundo = Instantiate(wallBack,
				newPosition, wallBack.transform.rotation);
			countWallBack++;
		}
		else
		{
			Debug.Log("Não é possível adicionar parede de fundo, limite atingido");
		}
	}
}
