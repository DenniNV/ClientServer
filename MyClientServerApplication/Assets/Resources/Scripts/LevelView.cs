using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelView : MonoBehaviour
{
    [SerializeField]
    private Scrollbar _levelBar;
    [SerializeField]
    private Text _percentageRatio;
    private void Update()
    {
        _percentageRatio.text = _levelBar.size *100 +"% " + " / " + "100%";
    }
}
