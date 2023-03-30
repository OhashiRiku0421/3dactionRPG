using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    private PlayerController _player;

    public MoveState(PlayerController player)
    {
        _player = player;
    }

    public void Enter()
    {
        _player.Renderer.color = Color.red;
        Debug.Log("Move");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _player.StateMachine.Change(_player.StateMachine.Attack);
        }
    }

    public void Exit()
    {
        
    }


}
