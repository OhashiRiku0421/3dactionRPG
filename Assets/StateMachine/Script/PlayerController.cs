using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private StateMachine _stateMachine;

    public StateMachine StateMachine => _stateMachine;

    private SpriteRenderer _renderer;

    public SpriteRenderer Renderer { get => _renderer; set => _renderer = value; }

    private void Awake()
    {
        _stateMachine = new StateMachine(this);
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _stateMachine.Init(_stateMachine.Idel);
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
