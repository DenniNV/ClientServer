using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoginUsers 
{
    readonly string url = "https://denisnvgames.000webhostapp.com/ChekoutUsers.php";

    public void CheckUser(string userName, string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("userNameCheck", userName);
        form.AddField("userPasswordCheck", password);
        UnityWebRequest Add = UnityWebRequest.Post(url, form);
        Add.SendWebRequest();
        if (Add.isNetworkError || Add.isHttpError)
        {
            Debug.Log("Error downloading: " + Add.error);
        }
        else
        {
            Debug.Log(Add.downloadHandler.text);
        }

    }

}
