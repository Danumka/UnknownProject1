using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public List<ItemData> inventoryItems = new List<ItemData>(); 
    public Transform itemPanel;
    public Transform Canvas;

    public void AddItemToInventory(string itemName, Sprite itemSprite)
    {
        ItemData newItem = new ItemData(itemName, itemSprite);
        inventoryItems.Add(newItem);
        Debug.Log(inventoryItems[0].itemName);
        GameObject parentObject = GameObject.Find("Background");
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            GameObject newSlot = new GameObject("slot" + (i + 1)); 
            Image image = newSlot.AddComponent<Image>(); 
            image.sprite = inventoryItems[i].itemSprite;
            newSlot.transform.SetParent(parentObject.transform);

            
        }
        
    }


    public void UseItemFromInventory(int index)
    {
            inventoryItems.RemoveAt(index); 
    }
public class ItemData
{
    public string itemName;
    public Sprite itemSprite;

    public ItemData(string name, Sprite sprite)
    {
        itemName = name;
        itemSprite = sprite;
    }
}
}