using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "SpartaDungeon/Items/New Item", order = 1)]

public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string itemname;
    public string description;
    public Sprite icon;

    [Header("Stat Info")]
    public CharacterStatSO itemStat;
}
