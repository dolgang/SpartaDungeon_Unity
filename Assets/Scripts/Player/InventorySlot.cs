using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Sprite icon;
    public Transform equippedImage;

    public int index;
    public bool isEquip = false;

    private Image _currentSlotImage;
    private InventoryPopupController _inventoryPopupControl;

    private void Awake()
    {
        equippedImage = transform.Find("Equip");
        _inventoryPopupControl = transform.GetComponentInParent<InventoryPopupController>();
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

    public void SetEquipPopup()
    {
        //_inventoryPopupControl.EquipPopupOpen();
    }

    public void SetEquipItem()
    {
        isEquip = !isEquip;

        Inventory.instance.ItemEquipStatUpdate(isEquip, index);
        if (Inventory.instance.inventory.Count <= index) return;
        equippedImage.gameObject.SetActive(isEquip);
    }
}
