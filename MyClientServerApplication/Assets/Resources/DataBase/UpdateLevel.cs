using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class UpdateLevel : MonoBehaviour, IUpdaterGameData {

    private string _url = "https://denisnvgames.000webhostapp.com/UpdateUserLevel.php";
   
    

    public IEnumerator LoadData(string name, int newValue)
    {

        WWWForm form = new WWWForm();
        form.AddField("user", name);
        form.AddField("newLevel", newValue);
        UnityWebRequest loadData = UnityWebRequest.Post(_url, form);
        yield return loadData.SendWebRequest();


    }

    public void Load(string name, int newValue)
    {
        StartCoroutine(LoadData(name, newValue));
    }
}
