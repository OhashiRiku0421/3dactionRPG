using UnityEngine;

public class AttackState : IState
{

    private PlayerController _player;

    public AttackState(PlayerController player)
    {
        _player = player;
    }

    public void Enter()
    {
        _player.Renderer.color = Color.blue;
        Debug.Log("Attack");
    }

    public void Update()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            if (!Input.GetKey(KeyCode.Return))
            {
                _player.StateMachine.Change(_player.StateMachine.Idel);
            }
            else
            {
                _player.StateMachine.Change(_player.StateMachine.Move);
            }
                
        }
    }

    public void Exit()
    {
        
    }


}
