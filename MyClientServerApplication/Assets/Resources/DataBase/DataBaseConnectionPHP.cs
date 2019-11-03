using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseConnectionPHP : MonoBehaviour, IDataBaseConnection 
{
    public Text t;
    public IEnumerator Connection()
    {
        WWWForm form = new WWWForm();
        form.AddField("W","S");
        UnityWebRequest download = UnityWebRequest.Post("https://denisnvgames.000webhostapp.com/index.php", form);
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
    private void Start()
    {
        StartCoroutine(Connection());
    }


}
