using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItem : MonoBehaviour
{
    public Image itemImage;       
    public TMP_Text quantityText; 

    public void UpdateSlot(Sprite icon, int quantity)
    {
        itemImage.sprite = icon;
        quantityText.text = quantity.ToString();
    }
}