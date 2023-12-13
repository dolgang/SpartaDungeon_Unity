using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    private List<ItemData> inventory = new List<ItemData>();
    

    private void Awake()
    {
        instance = this;
    }

    public void GetItem(ItemData item)
    {
        inventory.Add(item);
    }
}
