using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadWeaponCount 
{
    private string _url = "https://denisnvgames.000webhostapp.com/LoadWeaponCount.php";
    private string[] _weaponData;
    public string[] WeaponData { get => _weaponData; }
    public IEnumerator LoadData( string userName, string key)
    {
        WWWForm form = new WWWForm();
        form.AddField("userName", userName);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();
        if (loadData.downloadHandler.text != "" && !loadData.isHttpError && !loadData.isNetworkError && loadData.downloadHandler.text != "Error")
        {
            string UsersData = loadData.downloadHandler.text;
            _weaponData = UsersData.Split(';');
            for (int i = 0; i < _weaponData.Length; i++)
            {
                if (PlayerPrefs.HasKey(key + i))
                {
                    PlayerPrefs.DeleteKey(key + i);
                }
                PlayerPrefs.SetString(key + i, _weaponData[i]);
            }
        }
        else Debug.Log("Error");
    }
}
