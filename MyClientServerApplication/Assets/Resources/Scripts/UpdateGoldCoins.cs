using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UpdateGoldCoins : MonoBehaviour, IUpdaterGameData
{
    //TODO заменить ссылки и 2 форму 
    private string _url = "https://denisnvgames.000webhostapp.com/UpdateUserSilver.php";


    public IEnumerator LoadData(string name, int newValue)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", name);
        form.AddField("silver", newValue);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();
    }
    public void Load(string name, int newValue)
    {
        StartCoroutine(LoadData(name, newValue));
    }
}
