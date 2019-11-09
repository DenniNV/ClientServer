using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoginUsers 
{
    readonly string url = "https://denisnvgames.000webhostapp.com/ChekoutUsers.php";
    private  string _error = "Error you login or password false";
    private string _sucsess = "Ok comrad";
    public string CheckUser(string userName, string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("userNameCheck", userName);
        form.AddField("userPasswordCheck", password);
        UnityWebRequest Add = UnityWebRequest.Post(url, form);
        Add.SendWebRequest();
        if (Add.isNetworkError || Add.isHttpError)
        {
            return _error;
        }
        else
        {
            return _sucsess;
        }

    }
    

}
