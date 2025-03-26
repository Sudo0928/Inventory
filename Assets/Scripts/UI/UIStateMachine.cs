using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStateMachine
{
    protected UIManager manager;

    protected IState currentState;
    protected Stack<IState> prevStates = new Stack<IState>();

    public UIMainMenuState MainMenu { get; private set; }
    public UIStatusState Status { get; private set; }
    public UIInventoryState Inventory { get; private set; }

    public UIStateMachine(UIManager manager)
    {
        this.manager = manager;

        Init();
    }

    public void Init()
    {
        MainMenu = manager.GetComponentInChildren<UIMainMenuState>();
        MainMenu.Init(this);

        Status = manager.GetComponentInChildren<UIStatusState>();
        Status.Init(this);

        Inventory = manager.GetComponentInChildren<UIInventoryState>();
        Inventory.Init(this);

        ChangeState(MainMenu);
    }

    public void ChangeState(IState state)
    {
        currentState?.Exit();

        if (currentState != null) prevStates.Push(currentState);
        currentState = state;

        currentState.Enter();
    }

    public void PrevStateDataClear()
    {
        if (prevStates.Count > 0)
        {
            IState state = prevStates.Pop();
            prevStates.Clear();
            prevStates.Push(state);
        }
    }

    public void GoPreviousState()
    {
        currentState?.Exit();

        currentState = prevStates.Pop();

        currentState?.Enter();
    }
}
