using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    
    [SerializeField] private float speedX = 1;
    [SerializeField] private float speedY = 1;
    [SerializeField] private float speedZ = 1;

    [SerializeField] private bool correAutomatico;
    [SerializeField] private bool controlarComTeclado;

    [SerializeField] private bool shouldMoveX;

    [SerializeField] private bool shouldMoveY;

	[SerializeField] private bool shouldMoveZ;

    private const float FRACAO = 100f;
    private const float PARADO = 0f;
	private const string EIXO_X = "x";
	private const string EIXO_Y = "y";
	private const string EIXO_Z = "z";

	// Update is called once per frame
	void Update()
    {
        CorreComValoresFixos();
        ControlarComTeclado();
    }

    private void ControlarComTeclado()
    {
        if (controlarComTeclado)
        {
			if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))    // -x
			{
				Moviment(EIXO_X, -speedX);
			}
			if (Input.GetKey(KeyCode.S))    // -y
			{
				Moviment(EIXO_Y, -speedY);
			}
			if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    // +x
			{
				Moviment(EIXO_X, speedX);
			}
			if (Input.GetKey(KeyCode.W))    // +y
			{
				Moviment(EIXO_Y, speedY);
			}
			if (Input.GetKey(KeyCode.DownArrow))  // -z
			{
				Moviment(EIXO_Z, -speedZ);
			}
			if (Input.GetKey(KeyCode.UpArrow))    // +z
			{
				Moviment(EIXO_Z, speedZ);
			}
		}
    }

    private void Moviment(string eixo, float velocidade)
    {
        switch (eixo.ToLower())
        {
            case EIXO_X:
				Translate(new Vector3(FracionarSpeed(velocidade), PARADO, PARADO));
                break;
            case EIXO_Y:
				Translate(new Vector3(PARADO, FracionarSpeed(velocidade), PARADO));
				break;
            case EIXO_Z:
				Translate(new Vector3(PARADO, PARADO, FracionarSpeed(velocidade)));
				break;
		}
        
    }

    private void Translate(Vector3 translation)
    {
		transform.position += translation;
	}

    private float FracionarSpeed(float speed)
    {
        return speed / FRACAO;
    }

    private void CorreComValoresFixos()
    {
        if (correAutomatico)
        {
			if (shouldMoveX)
			{
				Translate(new Vector3(FracionarSpeed(speedX), PARADO, PARADO));
			}

			if (shouldMoveY)
			{
				Translate(new Vector3(PARADO, FracionarSpeed(speedY), PARADO));
			}

			if (shouldMoveZ)
			{
				Translate(new Vector3(PARADO, PARADO, FracionarSpeed(speedZ)));
			}
		}
    }
}
