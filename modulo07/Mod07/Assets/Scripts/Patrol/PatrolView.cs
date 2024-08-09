using TMPro;
using UnityEngine;

public class PatrolView : MonoBehaviour
{

	public TextMeshProUGUI TextMeshProUGUIStatus;
	public TextMeshProUGUI TextMeshProUGUIDirection;
	public Patrol PatrolComponent;

	void Start()
	{
		ExecutaTextAndStatus();
	}

	private void ExecutaTextAndStatus()
	{
		if (TextMeshProUGUIStatus != null && PatrolComponent != null && TextMeshProUGUIDirection != null)
		{
			TextMeshProUGUIStatus.text = "Idle";
			PatrolComponent.OnStartedMoving += OnStartedMovingEventHandler;
			PatrolComponent.OnStoppedMoving += OnStoppedMovingEventHandler;
		}
		else
		{
			if (TextMeshProUGUIDirection == null)
			{
				Debug.Log("[PatrolView.cs] Text de direction está null");
			}
			if (TextMeshProUGUIStatus == null)
			{
				Debug.Log("[PatrolView.cs] Text de status está null");
			}
			if (PatrolComponent == null)
			{
				Debug.Log("[PatrolView.cs] Patrol está  null");
			}
		}
	}

	private void OnStartedMovingEventHandler(bool isMovingRight)
	{
		TextMeshProUGUIStatus.text = "Moving";
		TextMeshProUGUIDirection.gameObject.SetActive(true);
		TextMeshProUGUIDirection.text = isMovingRight ? "Right" : "Left";
	}

	private void OnStoppedMovingEventHandler()
	{
		TextMeshProUGUIStatus.text = "Idle";
		TextMeshProUGUIDirection.text = null;
		TextMeshProUGUIDirection.gameObject.SetActive(false);
	}
}
