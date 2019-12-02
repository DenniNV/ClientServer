using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBossGameData : MonoBehaviour //, ILoderImageBoss
{
    private  DataBaseLoadBossData _bossData = new DataBaseLoadBossData();
    public int NumsBosses;

    [SerializeField]
    private Text _bossName;
    public Text BossName { get => _bossName; }

    [SerializeField]
    private Text _bossEXP;
    [SerializeField]
    private Text _bossGoldTooth;
    [SerializeField]
    private Text _bossGoldCoin;
    [SerializeField]
    private Image _bossImage;

    private int _exp;
    public int Exp { get => _exp; }

    private int _goldTooth;
    public int GoldTooth { get => _goldTooth; }

    private int _goldCoin;
    public int GoldCoin { get => _goldCoin; }

    private string _hp;
    public string Hp { get => _hp; }



    private void Awake()
    {
         Load(_bossData, NumsBosses);
        _bossName.text = PlayerPrefs.GetString("Boss" + NumsBosses + 0);
        _bossEXP.text = PlayerPrefs.GetString("Boss" + NumsBosses + 1);
        _bossGoldTooth.text = PlayerPrefs.GetString("Boss" + NumsBosses + 2);
        _bossGoldCoin.text = PlayerPrefs.GetString("Boss" + NumsBosses + 3);
        _exp = Convert.ToInt32( PlayerPrefs.GetString("Boss" + NumsBosses + 1));
        _goldTooth = Convert.ToInt32(PlayerPrefs.GetString("Boss" + NumsBosses + 2));
        _goldCoin = Convert.ToInt32(PlayerPrefs.GetString("Boss" + NumsBosses + 3));
        _hp = PlayerPrefs.GetString("Boss" + NumsBosses + 4);
    }

    private void Load(ILoadData load, int index)
    {
        StartCoroutine(load.LoadData(index , "Boss" + NumsBosses));
    }

    public Sprite BossImage()
    {
        return _bossImage.sprite;
    }
}
