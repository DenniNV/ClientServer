using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyView : MonoBehaviour
{
    //TODO
    private int _energynow = 0;
    public int MaxEnergy { set => _maxEnergy = value; get => _maxEnergy; }
    private int _maxEnergy = 100;
    [SerializeField]
    private Text _energyText;
    private delegate void UpdateText();
    private event UpdateText UpEnegy;

    private void Start()
    {
        StartCoroutine(EnergyReplenishment());
        UpEnegy?.Invoke();
    }

    IEnumerator EnergyReplenishment()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(60);
            if (_energynow < _maxEnergy)
            {
                _energynow++;
                UpEnegy?.Invoke();
            }
        }
    }
    private void Awake()
    {
        UpEnegy += UpdateView;
    }

    private void UpdateView()
    {
        _energyText.text = _energynow + " / " + _maxEnergy; 
    }


}
