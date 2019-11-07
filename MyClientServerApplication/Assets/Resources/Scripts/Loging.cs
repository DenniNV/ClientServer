using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loging : MonoBehaviour
{
    DataBaseLoginUsers loginUsers = new DataBaseLoginUsers();

    private void Start()
    {
        loginUsers.CheckUser("Laura11", "vfhrtnbyusss");
    }
}
