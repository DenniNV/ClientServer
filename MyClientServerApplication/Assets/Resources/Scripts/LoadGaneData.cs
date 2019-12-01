using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGaneData : MonoBehaviour
{
    private DataBaseLoadGameData _dataBase = new DataBaseLoadGameData();
    [SerializeField]
    private Text _username;
    [SerializeField]
    private Text _goldTooth;
    [SerializeField]
    private Text _goldCoin;
    [SerializeField]
    private Text _exp;


    private void Start()
    {

        _username.text = PlayerPrefs.GetString("userName");
        
    }

}
