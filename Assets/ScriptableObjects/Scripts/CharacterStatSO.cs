using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultCharacterData", menuName = "SpartaDungeon/Stats/Default", order = 0)]

public class CharacterStatSO : ScriptableObject
{
    [Header("Character Stat")]
    public int attack;
    public int defense;
    public int maxhealthPoint;
    public int criticalChance;
}
