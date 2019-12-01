using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadDistrictData : ILoadData
{
    private string _url = "https://denisnvgames.000webhostapp.com/DistrictLoad.php";
    private string[] _district;
    public string[] District { get => _district; }
    public IEnumerator LoadData(int id, string key)
    {
        WWWForm form = new WWWForm();
        form.AddField("districtId", id);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();
        if (loadData.downloadHandler.text != "" && !loadData.isHttpError && !loadData.isNetworkError && loadData.downloadHandler.text != "Error")
        {
            string UsersData = loadData.downloadHandler.text;
            _district = UsersData.Split(';');
            for (int i = 0; i < _district.Length; i++)
            {
                if (PlayerPrefs.HasKey(key + i))
                {
                    PlayerPrefs.DeleteKey(key + i);
                }
                PlayerPrefs.SetString(key + i, _district[i]);
            }
        }
        else Debug.Log("Error");
    }
}
