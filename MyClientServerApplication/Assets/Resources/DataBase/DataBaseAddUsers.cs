using UnityEngine;
using UnityEngine.Networking;
public class DataBaseAddUsers 
{
    readonly string url = "https://denisnvgames.000webhostapp.com/AddUsers.php";
    public void Connection(string userName , string password , string email)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernameAdd", userName);
        form.AddField("userpasswordAdd", password);
        form.AddField("useremailAdd", email);
        UnityWebRequest Add = UnityWebRequest.Post(url, form);
        Add.SendWebRequest();
       
    }
}
