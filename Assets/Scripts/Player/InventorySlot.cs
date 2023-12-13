using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Sprite icon;
    public Transform equippedImage;

    public int index;
    public bool isEquip;

    private Image _currentSlotImage;

    private void Awake()
    {
        equippedImage = transform.Find("Equip");
    }

    public void InvetoryItemDataUpdate(ItemData item)
    {
        icon = item.icon;
        if (equippedImage == null)
        {
            _currentSlotImage = transform.Find("Icon").GetComponent<Image>();
        }
        
        _currentSlotImage.sprite = icon;
    }
}
