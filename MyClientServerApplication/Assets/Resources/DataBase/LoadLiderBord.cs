using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadLiderBord 
{
    private string _url = "https://denisnvgames.000webhostapp.com/LiderBossKill.php";
    private string _userName;
    public string UserName { get => _userName; private set => _userName = value; }
    public delegate void Load();
    public event Load IsLoad;
    public IEnumerator LoadLider(string bossName)
    {
        WWWForm form = new WWWForm();
        form.AddField("bossId", bossName);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();
        UserName = loadData.downloadHandler.text;
        Debug.Log(UserName);
        IsLoad?.Invoke();

    }




   
}
