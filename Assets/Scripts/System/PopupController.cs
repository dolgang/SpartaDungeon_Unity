using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    [SerializeField] private GameObject statusPopup;
    [SerializeField] private GameObject inventoryPopup;
    [SerializeField] private GameObject statusButton;
    [SerializeField] private GameObject inventoryButton;

    private bool popupOpen = false;


    private void PopupButtonToggle()
    {
        if (popupOpen)
        {
            statusButton.SetActive(false);
            inventoryButton.SetActive(false);
        }
        else
        {
            statusButton.SetActive(true);
            inventoryButton.SetActive(true);
        }
    }

    public void StatusPopupOpen()
    {
        popupOpen = true;
        statusPopup.SetActive(true);
        PopupButtonToggle();
    }

    public void InventoryPopupOpen()
    {
        popupOpen = true;
        inventoryPopup.SetActive(true);
        PopupButtonToggle();
    }

    public void PopupClose()
    {
        statusPopup.SetActive(false);
        inventoryPopup.SetActive(false);
        popupOpen = false;
        PopupButtonToggle();
    }
}
