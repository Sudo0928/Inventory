using Unity.VisualScripting;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    private UIStateMachine stateMachine;

    private void Awake()
    {
        stateMachine = new UIStateMachine(this);
    }
}
