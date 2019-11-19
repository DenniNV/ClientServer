using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class DataBaseLoginUsers 
{
    readonly string url = "https://denisnvgames.000webhostapp.com/ChekoutUsers.php";
    private  string _error = "";
    private string _successful = "";
    private string _userLoadName = "";
    private UnityWebRequest _add;
    public string Error { get => _error;}
    public string Successful { get => _successful;}
    public string UserLoadName { get => _userLoadName;}
    public UnityWebRequest Add { get => _add; }

    public IEnumerator CheckUser(string userName, string password)
    {
        var form = new WWWForm();

        form.AddField("userNameCheck", userName);
        form.AddField("userPasswordCheck", password);
        _add =  UnityWebRequest.Post(url, form);
        yield return _add.SendWebRequest();
        if (_add.isNetworkError)
        {
            _error = "";
            LoginError(_add.downloadHandler.text);
            Debug.Log(_add.downloadHandler.text);
        }
        else if (_add.isHttpError)
        {
            _error = "";
            LoginError(_add.downloadHandler.text);
            Debug.Log(_add.downloadHandler.text);


        }
        else
        {
            if(_add.downloadHandler.text == "Come in comrade")
            {
                LoginError(_add.downloadHandler.text);
                _userLoadName = userName;
                if (_add.downloadProgress == 1)
                {
                  //  LoginSuccessful();
                }

            }
        }

    }



    private void LoginSuccessful()
    {
        SceneManager.LoadScene(1);
    }
    private void LoginError(string error)
    {
        _error = error;

    }


}
