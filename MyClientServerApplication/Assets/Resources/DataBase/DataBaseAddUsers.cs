﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
public class DataBaseAddUsers
{
    readonly string url = "https://denisnvgames.000webhostapp.com/AddUsers.php";
    private string _error;
    public string Error { get => _error; }
    private bool _registrationOk;
    public bool RegistrationOk { get => _registrationOk; }
    public IEnumerator Connection(string userName, string password, string email)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernameAdd", userName);
        form.AddField("userpasswordAdd", password);
        form.AddField("useremailAdd", email);
        UnityWebRequest Add = UnityWebRequest.Post(url, form);
        yield return Add.SendWebRequest();
        if (Add.isNetworkError|| Add.isHttpError)
        {

            Debug.Log("You have errors");
        }
        else
        {


            if (Add.downloadHandler.text == "this login use")
            {

                _error = "Камрад такой логин уже используют";
                _registrationOk = false;
            }
            else _registrationOk = true;


        }
       

    }
    
}
