using UnityEngine;

public class Move : MonoBehaviour
{
	public float Speed;
	public Vector3 Direction;

	private void Update()
	{
		Translate(Direction * Speed * Time.deltaTime);
	}

	private void Translate(Vector3 translation)
	{
		transform.position += translation;
	}
}
