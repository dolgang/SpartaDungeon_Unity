using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

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
    private Inventory _inventory;
    private GameObject _player;

    public List<ItemData> itemdatas = new List<ItemData>();


    private void Awake()
    {
        instance = this;
        _player = GameObject.FindGameObjectWithTag(playerTag);
        _characterStatsHandler = _player.GetComponent<CharacterStatsHandler>();
        _inventory = _player.GetComponent<Inventory>();
    }

    private void Start()
    {
        PlayerStatUpdate();
        for (int i = 0; i < itemdatas.Count; i++)
        {
            _inventory.GetItem(itemdatas[i]);
        }
    }

    private void PlayerStatUpdate()
    {
        attackText.text = _characterStatsHandler.CurrentStats.statSO.attack.ToString();
        defenseText.text = _characterStatsHandler.CurrentStats.statSO.defense.ToString();
        maxHealthText.text = _characterStatsHandler.CurrentStats.statSO.maxhealthPoint.ToString();
        criticalChanceText.text = _characterStatsHandler.CurrentStats.statSO.criticalChance.ToString();
    }
}
