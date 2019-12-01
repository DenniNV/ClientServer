using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoadGameData
{
    DataBaseLoginUsers loginUsers = new DataBaseLoginUsers();
    readonly string url = "https://denisnvgames.000webhostapp.com/LoadUsersData.php";
    [SerializeField]
    private string[] userData;
    public string[] UserData { get => userData; }
    
    public IEnumerator LoadGameData(string UserName)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", UserName);
        UnityWebRequest loadData = UnityWebRequest.Post(url, form);
        yield return loadData.SendWebRequest();
        if (loadData.downloadHandler.text != "" && !loadData.isHttpError&&!loadData.isNetworkError && loadData.downloadHandler.text != "Error")
        {
            string UsersData = loadData.downloadHandler.text;
            Debug.Log(UsersData);
            userData = UsersData.Split(';');
            for (int i = 0; i < userData.Length; i++)
            {
                userData = UsersData.Split(';');
                if (PlayerPrefs.HasKey("UsersData" + i))
                {
                    PlayerPrefs.DeleteKey("UsersData" + i);
                }
                PlayerPrefs.SetString("UsersData" + i, userData[i]);
            }
            if (loadData.uploadProgress == 1 && loadData.downloadProgress == 1)
            {
                loginUsers.LoginSuccessful();
            }
        }
        else Debug.Log("Error");
    }

}
