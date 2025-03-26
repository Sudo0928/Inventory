using UnityEngine;

public abstract class UIState : MonoBehaviour, IState
{
    protected UIStateMachine stateMachine;
    protected CanvasGroup CanvasGroup;

    public virtual void Init(UIStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
        CanvasGroup = GetComponent<CanvasGroup>();
        Exit();
    }

    public virtual void Enter()
    {
        CanvasGroup.alpha = 1.0f;
        CanvasGroup.blocksRaycasts = true;
        CanvasGroup.interactable = true;
    }

    public virtual void Exit()
    {
        CanvasGroup.alpha = 0f;
        CanvasGroup.blocksRaycasts = false;
        CanvasGroup.interactable = false;
    }

    public virtual void GoPrev()
    {
        stateMachine.GoPreviousState();
    }
}
