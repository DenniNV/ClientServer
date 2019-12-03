using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewLiderBord : MonoBehaviour
{
    private LoadLiderBord _liderBord = new LoadLiderBord();
    [SerializeField]
    private Text _liderText;
    public string BossName = "";
    private void OnValidate()
    {
        if(BossName == "")
        {

            _liderText.text = "You don't write boss name";
        }
    }
    void Start()
    {
        StartCoroutine(_liderBord.LoadLider(BossName));
        _liderBord.IsLoad += ViewLider;
    }
    private void ViewLider()
    {
        _liderText.text = "Граза босса игрок с ником " + _liderBord.UserName;
    }
}
