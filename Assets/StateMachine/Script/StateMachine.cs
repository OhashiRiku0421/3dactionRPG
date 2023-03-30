using System;
using UnityEngine;

public class StateMachine
{
    private IState _state;

    private AttackState _attack;

    public AttackState Attack => _attack;

    private MoveState _move;

    public MoveState Move => _move;

    private IdelState _idle;

    public IdelState Idel => _idle;

    private event Action<IState> _stateChanged;

    public StateMachine(PlayerController player)
    {
        _attack = new AttackState(player);
        _move = new MoveState(player);
        _idle = new IdelState(player);
    }

    /// <summary>
    /// 初期化
    /// </summary>
    public void Init(IState state)
    {
        _state = state;
        state.Enter();
        _stateChanged ?.Invoke(state);

    }

    /// <summary>
    /// ステートが変わる時に実行する
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
