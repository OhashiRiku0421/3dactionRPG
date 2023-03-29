using System;
using UnityEngine;

public class StateMachine
{
    private IState _state;

    private AttackState _attack;

    private MoveState _move;

    private IdelState _idle;

    private event Action<IState> _stateChanged;

    public StateMachine(PlayerController player)
    {
        _attack = new AttackState(player);
        _move = new MoveState(player);
        _idle = new IdelState(player);
    }

    /// <summary>
    /// ������
    /// </summary>
    private void Init(IState state)
    {
        _state = state;
        state.Enter();
        _stateChanged ?.Invoke(state);

    }

    /// <summary>
    /// �X�e�[�g���ς�鎞�Ɏ��s����
    /// </summary>
    public void Change(IState nextState)
    {
        _state.Exit();
        _state = nextState;
        nextState.Enter();
        _stateChanged?.Invoke(nextState);
    }

    public void Update()
    {
        _state.Update();
    }
}
