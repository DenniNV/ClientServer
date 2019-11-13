using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loging : MonoBehaviour
{
    private DataBaseLoginUsers _loginUsers = new DataBaseLoginUsers();
    private CheckerIputData _inputData = new CheckerIputData();
    [SerializeField]
    private InputField _loginInput;
    [SerializeField]
    private InputField _passwordInput;
    [SerializeField]
    private Button _buttonOk;
    [SerializeField]
    private Button _buttonErrorOk;
    [SerializeField]
    private Text _logText;
    [SerializeField]
    private GameObject _errorPanel;

    private void Start()
    {
        _buttonOk.onClick.AddListener(() => LogingUsers());
        _buttonErrorOk.onClick.AddListener(() => ClosePanelError());
    }
    private void LogingUsers()
    {
        _logText.text = "";
        if (_inputData.CheckUserName(_loginInput.text) && _inputData.CheckUserPassword(_passwordInput.text))
        {
            StartCoroutine(_loginUsers.CheckUser(_loginInput.text, _passwordInput.text));
            _errorPanel.SetActive(true);
            _logText.text = _loginUsers.Error;
        }
        else
        {
            _errorPanel.SetActive(true);
            _logText.text = "Камрад ты ввел неправильные данные";
        }
    }
    private void ClosePanelError()
    {

        _errorPanel.SetActive(false);
    }



}
