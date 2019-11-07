using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConnection : MonoBehaviour
{
     DataBaseConnectionPHP _connectionPHP = new DataBaseConnectionPHP();
    void Start()
    {
        Connection(_connectionPHP);
    }

    private void Connection(IDataBaseConnection  dataBase)
    {
       StartCoroutine( dataBase.Connection());

    }
}
