using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<ItemData> inventory = new List<ItemData>();
    public InventorySlot[] slots;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].index = i;
        }
    }

    public void GetItem(ItemData item)
    {
        inventory.Add(item);
        InventoryUIUpdate();
    }

    private void InventoryUIUpdate()
    {
        for (int i = 0; i < inventory.Count ;i++)
        {
            slots[i].InvetoryItemDataUpdate(inventory[i]);
        }
    }

    public void ItemEquipStatUpdate(bool isEquip, int index)
    {
        if (isEquip)
        {
            GameManager.instance.PlayerCharacterStatsHandler.AddStatModifier(inventory[index].itemStat);
            GameManager.instance.PlayerStatUpdate();
            //Debug.Log("Add!" + index);
        }
        else
        {
            GameManager.instance.PlayerCharacterStatsHandler.RemoveStatModifier(inventory[index].itemStat);
            GameManager.instance.PlayerStatUpdate();
            //Debug.Log("Remove!" + index);
        }
    }
}
