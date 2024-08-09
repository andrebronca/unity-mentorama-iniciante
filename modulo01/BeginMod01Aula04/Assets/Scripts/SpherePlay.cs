using UnityEngine;

public class SpherePlay : MonoBehaviour
{
	private new Rigidbody rigidbody;
	public float speed = 1.0f;
	private bool isStopped;

	// Start is called before the first frame update
	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		isStopped = true;

		if (rigidbody != null)
		{
			//rigidbody.useGravity = false;
			//rigidbody.isKinematic = true;
			StartFreeFall(false);
		}
	}

	// Update is called once per frame
	void Update()
	{
		KeyPressed();
	}

	private void KeyPressed()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartFreeFall(true);
			isStopped = false;
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			StartFreeFall(false);
			isStopped = true;
		}

	}
	private void StartFreeFall(bool flag)
	{
		rigidbody.useGravity = flag;

		//se true impede o objeto de ser afetado pela física
		rigidbody.isKinematic = !flag;
	}

	private void FixedUpdate()
	{
		ListenningKeyPressed();
	}

	private void ListenningKeyPressed()
	{
		if (isStopped)
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.up * speed * Time.fixedDeltaTime);
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.down * speed * Time.fixedDeltaTime);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.right * speed * Time.fixedDeltaTime);
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.left * speed * Time.fixedDeltaTime);
			}
			if (Input.GetKey(KeyCode.Q))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.forward * speed * Time.fixedDeltaTime);
			}
			if (Input.GetKey(KeyCode.R))
			{
				rigidbody.MovePosition(rigidbody.position + Vector3.back * speed * Time.fixedDeltaTime);
			}
		}
	}

}
