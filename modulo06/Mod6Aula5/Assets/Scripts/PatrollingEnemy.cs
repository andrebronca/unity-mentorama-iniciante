using System;
using UnityEngine;

public class PatrollingEnemy : MonoBehaviour
{
	enum EnemyState
	{
		Stopped, Patrolling1, Patrolling2
	}

	enum PatrolDirection
	{
		Left, Right
	}

	[Serializable]
	struct PatrolData
	{
		//tempo de patrulhamento
		public float Duration;
		//velocidade do patrulhamento
		public float MoveSpeed;
		//tempo de patrulhamento em uma direção
		public float MoveDirectionDuration; //valor final que será comparado
	}

	[SerializeField] EnemyState currentEnemyState;
	[SerializeField] PatrolData patrolData1;
	[SerializeField] PatrolData patrolData2;

	private float startPatrollTime;
	PatrolDirection currentPatrolDirection;
	private float directionChangeTime;  //valor dinâmico


	// Start is called before the first frame update
	void Start()
	{
		currentEnemyState = EnemyState.Stopped;
		currentPatrolDirection = PatrolDirection.Right;
		directionChangeTime = 0;
	}

	// Update is called once per frame
	void Update()
	{
		VerifyEnemyState(currentEnemyState);

	}

	void Translate(Vector3 translation)
	{
		transform.position += translation;
	}

	void VerifyEnemyState(EnemyState state)
	{
		switch (state)
		{
			case EnemyState.Stopped:
				if (Input.GetKeyDown(KeyCode.Space))
				{
					currentEnemyState = EnemyState.Patrolling1;
					startPatrollTime = Time.time;
				}
				break;
			case EnemyState.Patrolling1:
				if (Time.time > startPatrollTime + patrolData1.Duration)
				{
					currentEnemyState = EnemyState.Patrolling2;
					startPatrollTime = Time.time;
				}
				else
				{
					PatrolRoutine(patrolData1);
				}
				break;
			case EnemyState.Patrolling2:
				if (Time.time > startPatrollTime + patrolData2.Duration)
				{
					currentEnemyState = EnemyState.Stopped;
				}
				else
				{
					PatrolRoutine(patrolData2);
				}
				break;
		}
	}

	void ChangePatrolDirection(PatrolDirection direction, PatrolData patrolData)
	{
		if (directionChangeTime > patrolData.MoveDirectionDuration)
		{
			currentPatrolDirection = direction;
			directionChangeTime = 0;
		}
	}

	void PatrolRoutine(PatrolData patrolData)
	{
		directionChangeTime += Time.deltaTime;

		switch (currentPatrolDirection)
		{
			case PatrolDirection.Right:
				ChangePatrolDirection(PatrolDirection.Left, patrolData);
				Translate(new Vector3(patrolData.MoveSpeed * Time.deltaTime, 0, 0));
				break;
			case PatrolDirection.Left:
				ChangePatrolDirection(PatrolDirection.Right, patrolData);
				Translate(new Vector3(-patrolData.MoveSpeed * Time.deltaTime, 0, 0));
				break;

		}
	}
}
