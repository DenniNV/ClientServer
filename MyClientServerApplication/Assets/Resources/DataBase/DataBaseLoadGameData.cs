using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoadGameData
{
    readonly string url = "https://denisnvgames.000webhostapp.com/LoadUsersData.php";
    public string[] userData;
    public IEnumerator LoadGameData(string userName)
    {
        WWWForm form = new WWWForm();
        form.AddField("userNameLoad", userName);
        UnityWebRequest loadData = UnityWebRequest.Post(url, form);
        yield return loadData.SendWebRequest();
        string UsersData = loadData.downloadHandler.text;
        if(loadData.downloadHandler != null)
        {
            userData = UsersData.Split(';');
           for(int i  = 0; i<userData.Length; i++)
           {
                userData = UsersData.Split(';');
                Debug.Log(userData[i] + " ");
           }
        }
        
    }

}
