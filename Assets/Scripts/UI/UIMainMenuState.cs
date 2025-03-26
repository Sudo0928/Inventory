using UnityEngine;
using UnityEngine.UI;

public class UIMainMenuState : UIState
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    public override void Enter()
    {
        base.Enter();

        stateMachine.PrevStateDataClear();

        statusButton.onClick.AddListener(OnClickStatusButton);
        inventoryButton.onClick.AddListener(OnClickInventoryButton);
    }

    public override void Exit()
    {
        base.Exit();

        statusButton.onClick.RemoveListener(OnClickStatusButton);
        inventoryButton.onClick.RemoveListener(OnClickInventoryButton);
    }

    private void OnClickStatusButton()
    {
        stateMachine.ChangeState(stateMachine.Status);
    }

    private void OnClickInventoryButton()
    {
        stateMachine.ChangeState(stateMachine.Inventory);
    }
}
