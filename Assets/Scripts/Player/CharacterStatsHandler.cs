using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterInfo characterStats;
    public CharacterInfo CurrentStats { get; private set; }
    public List<CharacterStatSO> statsModifiers = new List<CharacterStatSO>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    public void AddStatModifier(CharacterStatSO statModifier)
    {
        statsModifiers.Add(statModifier);
        UpdateCharacterStats();
    }

    public void RemoveStatModifier(CharacterStatSO statModifier)
    {
        statsModifiers.Remove(statModifier);
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        CharacterStatSO statSO = null;
        if (characterStats.statSO != null)
        {
            statSO = Instantiate(characterStats.statSO);
        }

        CurrentStats = new CharacterInfo { statSO = statSO };

        foreach (var modifier in statsModifiers)
        {
            UpdateStats((o, o1) => o + o1, modifier);
        }
        
    }

    private void UpdateStats(Func<int, int, int> operation, CharacterStatSO modifier)
    {
        if (characterStats.statSO == null || modifier == null) return;

        CurrentStats.statSO.attack = operation(CurrentStats.statSO.attack, modifier.attack);
        CurrentStats.statSO.defense = operation(CurrentStats.statSO.defense, modifier.defense);
        CurrentStats.statSO.maxhealthPoint = operation(CurrentStats.statSO.maxhealthPoint, modifier.maxhealthPoint);
        CurrentStats.statSO.criticalChance = operation(CurrentStats.statSO.criticalChance, modifier.criticalChance);
    }
}
