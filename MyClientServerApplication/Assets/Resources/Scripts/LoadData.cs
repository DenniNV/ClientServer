using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    private DataBaseLoadGameData _loadGameData  = new DataBaseLoadGameData();
    private string _userName ;
    private string _goldCoin;
    private string _goldTooth;
    private string _level;


    [SerializeField]
    private Text _userNameText;

    [SerializeField]
    private Text _goldCoinText;

    [SerializeField]
    private Text _goldToothText;

    [SerializeField]
    private Text _leveText;


   
    private void Start()
    {
        _userName = PlayerPrefs.GetString("UsersData0");
        _goldCoin = PlayerPrefs.GetString("UsersData1");
        _goldTooth = PlayerPrefs.GetString("UsersData2");
        _level = PlayerPrefs.GetString("UsersData3");

        _userNameText.text = _userName;
        _goldCoinText.text = _goldCoin;
        _goldToothText.text = _goldTooth;
        _leveText.text = "Level " +_level;

    }



}
