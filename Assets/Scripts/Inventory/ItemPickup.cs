using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public InventorySystem inventorySystem;
    public string itemName;
    public Sprite itemSprite;

    private void OnClick()
    {
        if (inventorySystem != null)
        {
            Debug.Log("click!");
            inventorySystem.AddItemToInventory(itemName, itemSprite);
            gameObject.SetActive(false);
        }
    }

    public Button button;

    private void Start()
    {
        button.onClick.AddListener(OnClick);
    }
}