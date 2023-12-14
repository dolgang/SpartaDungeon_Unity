using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPopupController : MonoBehaviour
{
    public GameObject equipPopup;
    public TMP_Text equipConfirmText;
    private InventorySlot _currentSlot;

    public InventorySlot CurrentSlot
    {
        set { _currentSlot = value; }
    }


    public void EquipPopupOpen(bool isEquip)
    {
        if (!isEquip)
        {
            equipConfirmText.text = "Equip?";
        }
        else
        {
            equipConfirmText.text = "UnEquip?";
        }

        equipPopup.SetActive(true);
    }

    public void EquipPopupCancel()
    {
        equipPopup.SetActive(false);
    }

    public void EquipChangeConsent()
    {
        equipPopup.SetActive(false);

        _currentSlot.ToggleEquipItem();
    }
}
