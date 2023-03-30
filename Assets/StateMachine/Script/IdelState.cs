using UnityEngine;

public class IdelState : IState
{
    private PlayerController _player;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public IdelState(PlayerController player)
    {
        _player = player;
    }

    public void Enter()
    {
        //色を変える
        _player.Renderer.color = Color.white;
        Debug.Log("Idel");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            _player.StateMachine.Change(_player.StateMachine.Move);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            _player.StateMachine.Change(_player.StateMachine.Attack);
        }
    }

    public void Exit()
    {

    }


}
