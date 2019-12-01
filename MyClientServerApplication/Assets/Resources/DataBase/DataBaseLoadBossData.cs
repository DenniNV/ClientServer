using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataBaseLoadBossData : ILoadData
{
    private string _url = "https://denisnvgames.000webhostapp.com/LoadBossData.php";
    private string[] _bossData;
    public string[] BossData { get => _bossData; }
    public IEnumerator LoadData(int id , string key )
    {
        WWWForm form = new WWWForm();
        form.AddField("bossId", id);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();
        if (loadData.downloadHandler.text != "" && !loadData.isHttpError && !loadData.isNetworkError && loadData.downloadHandler.text != "Error")
        {
            string UsersData = loadData.downloadHandler.text;
            _bossData = UsersData.Split(';');
            for (int i = 0; i < _bossData.Length; i++)
            {
                if (PlayerPrefs.HasKey(key + i))
                {
                    PlayerPrefs.DeleteKey(key + i);
                }
                PlayerPrefs.SetString(key + i, _bossData[i]);
            }
        }
        else Debug.Log("Error");
    }

    
}
