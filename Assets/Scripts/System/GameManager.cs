using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private string playerTag = "Player";

    [SerializeField] private TMP_Text levelText;
    [SerializeField] private TMP_Text goldText;

    [SerializeField] private TMP_Text attackText;
    [SerializeField] private TMP_Text defenseText;
    [SerializeField] private TMP_Text maxHealthText;
    [SerializeField] private TMP_Text criticalChanceText;

    private CharacterStatsHandler _characterStatsHandler;


    private void Awake()
    {
        instance = this;
        _characterStatsHandler = GameObject.FindGameObjectWithTag(playerTag).GetComponent<CharacterStatsHandler>();
    }

    private void Start()
    {
        PlayerStatUpdate();
    }

    private void PlayerStatUpdate()
    {
        
        attackText.text = _characterStatsHandler.CurrentStats.statSO.attack.ToString();
        defenseText.text = _characterStatsHandler.CurrentStats.statSO.defense.ToString();
        maxHealthText.text = _characterStatsHandler.CurrentStats.statSO.maxhealthPoint.ToString();
        criticalChanceText.text = _characterStatsHandler.CurrentStats.statSO.criticalChance.ToString();
    }
}
