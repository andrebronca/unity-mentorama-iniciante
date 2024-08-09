using System;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	private enum PatrolState
	{
		Idle,
		PatrollingLeft,
		PatrollingRight
	}

	public Move MoveComponent;
	public event Action OnStoppedMoving;    //PatrolView.cs faz a execução
	public event Action<bool> OnStartedMoving;  //Invoke(bool)

	private PatrolData _patrolData;
	private PatrolState _patrolState;
	private PatrolState _lastMoveDirection;
	private float _idleTimer;
	private float _moveTimer;
	private bool _isPatrolling = false;

	private void Update()
	{
		if (!_isPatrolling) return;
		if (MoveComponent == null) return;

		switch (_patrolState)
		{
			default:
			case PatrolState.Idle:
				_idleTimer += Time.deltaTime;
				if (_idleTimer >= _patrolData.IdleDuration)
				{
					if (_lastMoveDirection == PatrolState.PatrollingLeft)
					{
						_patrolState = PatrolState.PatrollingRight;
						MoveComponent.Direction = Vector3.right;
						OnStartedMoving?.Invoke(true);
					}
					else
					{
						_patrolState = PatrolState.PatrollingLeft;
						MoveComponent.Direction = Vector3.left;
						OnStartedMoving?.Invoke(false);
					}

					MoveComponent.Speed = _patrolData.MoveSpeed;
					_idleTimer = 0;
				}

				break;
			case PatrolState.PatrollingLeft:
			case PatrolState.PatrollingRight:
				_moveTimer += Time.deltaTime;

				if (_moveTimer >= _patrolData.MoveDuration)
				{
					_lastMoveDirection = _patrolState;
					_patrolState = PatrolState.Idle;
					_moveTimer = 0;
					MoveComponent.Speed = 0;
					OnStoppedMoving?.Invoke();
				}

				break;

		}
	}

	public void StartPatrolling(PatrolData patrolData)
	{
		_patrolData = patrolData;
		_isPatrolling = true;
		_idleTimer = 0;
		_moveTimer = 0;
		_patrolState = PatrolState.Idle;
		_lastMoveDirection = PatrolState.PatrollingLeft;
	}

	public void StopPatrolling()
	{
		MoveComponent.Direction = Vector3.zero;
		MoveComponent.Speed = 0;
		_isPatrolling = false;
		OnStoppedMoving?.Invoke();
	}
}
