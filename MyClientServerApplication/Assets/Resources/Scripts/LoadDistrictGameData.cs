using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDistrictGameData : MonoBehaviour
{
    private LoadDistrictData districtData = new LoadDistrictData();
    public int NumDist;
    [SerializeField]
    private Text _dissName;
    [SerializeField]
    private Text _dissEXP;
    [SerializeField]
    private Text _disTooth;
    private int _exp;
    private int _goldTooth;
    private void Awake()
    { 
        Load(districtData, NumDist);
        _dissName.text = PlayerPrefs.GetString("Dist" + NumDist + 0);
        _dissEXP.text = PlayerPrefs.GetString("Dist" + NumDist + 1);
        _disTooth.text = PlayerPrefs.GetString("Dist" + NumDist + 2);
        _exp = Convert.ToInt32(PlayerPrefs.GetString("Dist" + NumDist + 1));
    }
    private void Load(ILoadData load, int index)
    {
        StartCoroutine(load.LoadData(index, "Dist" + NumDist));
    }
}
