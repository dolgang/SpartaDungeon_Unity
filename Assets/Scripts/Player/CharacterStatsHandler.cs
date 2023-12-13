using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats characterStats;
    public CharacterStats CurrentStats { get; private set; }

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        CharacterStatSO statSO = null;
        if (characterStats.statSO != null)
        {
            statSO = Instantiate(characterStats.statSO);
        }

        CurrentStats = new CharacterStats { statSO = statSO };
    }
}
