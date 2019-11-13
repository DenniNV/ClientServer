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

    public string Error { get => _error;}
    public string Successful { get => _successful;}

    public IEnumerator CheckUser(string userName, string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("userNameCheck", userName);
        form.AddField("userPasswordCheck", password);
        UnityWebRequest Add = UnityWebRequest.Post(url, form);
        yield return Add.SendWebRequest();
        if (Add.isNetworkError || Add.isHttpError)
        {
            _error = "";
            LoginError(Add.downloadHandler.text);
            Debug.Log(Add.downloadHandler.text);
        }
        else
        {
            LoginError(Add.downloadHandler.text);
            if(Add.downloadHandler.text == "Come in comrade")
            {
                LoginSuccessful();
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
