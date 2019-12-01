using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameObjectData : MonoBehaviour
{
    private  DataBaseLoadBossData _bossData = new DataBaseLoadBossData();
    public int NumsBosses;
    [SerializeField]
    private Text _bossName;
    [SerializeField]
    private Text _bossEXP;
    [SerializeField]
    private Text _bossGoldTooth;
    [SerializeField]
    private Text _bossGoldCoin;
    private int _exp;
    private int _goldTooth;
    private int _goldCoin;
    private void Start()
    {
        Load(_bossData, NumsBosses);
        _bossName.text = PlayerPrefs.GetString(NumsBosses.ToString() + 0);
        _bossEXP.text = PlayerPrefs.GetString(NumsBosses.ToString() + 1);
        _bossGoldTooth.text = PlayerPrefs.GetString(NumsBosses.ToString() + 2);
        _bossGoldCoin.text = PlayerPrefs.GetString(NumsBosses.ToString() + 3);
        _exp = Convert.ToInt32( PlayerPrefs.GetString(NumsBosses.ToString() + 1));
        print(_bossName.text  + _exp);
    }
    private void Load(ILoadData load, int index)
    {
        StartCoroutine(load.LoadData(index , NumsBosses.ToString()));
    }

}
