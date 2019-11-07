using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseConnectionPHP : MonoBehaviour, IDataBaseConnection 
{
    public IEnumerator Connection()
    {
        WWWForm form = new WWWForm();
        form.AddField("W","S");
        UnityWebRequest download = UnityWebRequest.Post("https://denisnvgames.000webhostapp.com/SelectUsers.php", form);
        yield return download.SendWebRequest();
        if (download.isNetworkError || download.isHttpError)
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            print(download.downloadHandler.text);
        }
    }
  


}
