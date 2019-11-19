using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoadGameData
{
    readonly string url = "https://denisnvgames.000webhostapp.com/LoadUsersData.php";
    [SerializeField]
    private string[] userData;
    public string[] UserData { get => userData; }
    
    public IEnumerator LoadGameData(string userName)
    {
        WWWForm form = new WWWForm();
        form.AddField("userNameLoad", userName);
        UnityWebRequest loadData = UnityWebRequest.Post(url, form);
        yield return loadData.SendWebRequest();
        if (loadData.isModifiable)
        {

            string UsersData = loadData.downloadHandler.text;
            if (loadData.downloadHandler != null)
            {
                userData = UsersData.Split(';');
                for (int i = 0; i < userData.Length; i++)
                {
                    userData = UsersData.Split(';');
                    //if(PlayerPrefs.HasKey("UsersData" + i))
                    //{

                    //    PlayerPrefs.DeleteKey("UsersData" + i);
                    //}
                    //PlayerPrefs.SetString("UsersData" + i, userData[i]);
                    Debug.Log(userData[i]);
                }
            }
        }
    }

}
