using UnityEngine;
using UnityEngine.UI;

public class UIInventoryState : UIState
{
    [SerializeField] private Button prevButton;

    public override void Enter()
    {
        base.Enter();
        prevButton.onClick.AddListener(GoPrev);
    }

    public override void Exit()
    {
        base.Exit();
        prevButton.onClick.RemoveListener(GoPrev);
    }
}
