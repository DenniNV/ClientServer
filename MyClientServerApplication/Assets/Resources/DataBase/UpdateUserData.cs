using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UpdateUserData : MonoBehaviour
{
    //private DataBaseLoginUsers _loginUsers = new DataBaseLoginUsers();

    private string _userName;
    private UpdateSilver _updateSilver;
    private UpdateLevel _updateLevel;
    private UpdateGoldCoins _updateGoldCoins;
    private UpdateBossKill _updateBossKill;
    private UpdateGooldTooth _updateGooldTooth;
    public delegate void LoadLevel();
    public event LoadLevel UpdateLevel;

    private void Start()
    {
        _userName = PlayerPrefs.GetString("UserLogin");
        UpdateLevel += UpLevel;
        UpdateLevel?.Invoke();
    }
    [Inject]
    private void Constructor( UpdateLevel updateLevel , UpdateGoldCoins updateGoldCoins ,
        UpdateGooldTooth updateGooldTooth , UpdateSilver updateSilver, 
        UpdateBossKill updateBossKill)
    {

        _updateSilver = updateSilver;
        _updateLevel = updateLevel;
        _updateGoldCoins = updateGoldCoins;
        _updateGooldTooth = updateGooldTooth;
        _updateBossKill = updateBossKill;


    }
    //TODO Сделать апдейт для все классов реализующие IUpdaterGameData
    private void UpSomthing(IUpdaterGameData updaterGameData)
    {  
        updaterGameData.Load(_userName, 1);

    }
    private void UpLevel()
    {

        UpSomthing(_updateLevel);
    }




}
