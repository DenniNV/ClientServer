using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBossGameData : MonoBehaviour
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
    private void Awake()
    {
        Load(_bossData, NumsBosses);
        _bossName.text = PlayerPrefs.GetString("Boss" + NumsBosses + 0);
        _bossEXP.text = PlayerPrefs.GetString("Boss" + NumsBosses + 1);
        _bossGoldTooth.text = PlayerPrefs.GetString("Boss" + NumsBosses + 2);
        _bossGoldCoin.text = PlayerPrefs.GetString("Boss" + NumsBosses + 3);
        _exp = Convert.ToInt32( PlayerPrefs.GetString("Boss" + NumsBosses + 1));
        print(_exp);
    }
    private void Load(ILoadData load, int index)
    {
        StartCoroutine(load.LoadData(index , "Boss" + NumsBosses));
    }
    
}
