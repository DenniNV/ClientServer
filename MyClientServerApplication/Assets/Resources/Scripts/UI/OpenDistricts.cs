using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDistricts : MonoBehaviour
{
    [SerializeField]
    private Button _open;
    [SerializeField]
    private GameObject _panel;
    private void Start()
    {
        _open.onClick.RemoveAllListeners();
        _open.onClick.AddListener(() => Open());
    }
    private void Open()
    {

        if (_panel.activeInHierarchy)
        {
            _panel.SetActive(false);
        }
        else _panel.SetActive(true);
    }
}
