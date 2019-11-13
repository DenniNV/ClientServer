using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseConnectionPHP :  IDataBaseConnection 
{

    public IEnumerator Connection()
    {
        WWWForm form = new WWWForm();
        form.AddField("S","W");
        UnityWebRequest download = UnityWebRequest.Post("https://denisnvgames.000webhostapp.com/CheckConnect.php", form);
        yield return download.SendWebRequest();
        if (download.isNetworkError || download.isHttpError)
        {
            Debug.Log("Error downloading: " + download.error);
        }
        else
        {
            Debug.Log(download.downloadHandler.text);
        }
    }
  


}
