using UnityEngine;

public class Character : MonoBehaviour
{
    public Inventory inventory;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
        inventory.Init();
    }
}
