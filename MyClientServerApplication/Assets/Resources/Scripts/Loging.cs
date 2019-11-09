using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loging : MonoBehaviour
{
    private DataBaseLoginUsers _loginUsers = new DataBaseLoginUsers();
    [SerializeField]
    private InputField _loginInput;
    [SerializeField]
    private InputField _passwordInput;
    [SerializeField]
    private Button _buttonOk;
    [SerializeField]
    private Text _logText;

    private void Start()
    {
        _buttonOk.onClick.AddListener(() => LogingUsers());
    }
    private void LogingUsers()
    {

        if(_loginInput.text != " " && _passwordInput.text != " ")
        {
            _logText.text = _loginUsers.CheckUser(_loginInput.text, _passwordInput.text);
                    

        }

    }



}
