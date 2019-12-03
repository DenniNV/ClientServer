using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BossFigthController : MonoBehaviour
{

    private ViewWeaponCount _weaponCount;
    private Weapon _weapon = new Weapon();
    [SerializeField]
    private GameObject _panelWin;
    [SerializeField]
    private GameObject _panelLose;
    [SerializeField]
    private GameObject _attackPanel;
    
    private void Awake()
    {
        _weaponCount = GetComponent<ViewWeaponCount>();
    }
    private void Start()
    {
        _weaponCount.YouWin += EndFight;
        _weaponCount.StartFight += StartFight;
    }

    public void Damage1()
    {
        _weaponCount.Punch(_weapon.Damage1);
    }
    public void Damage2()
    {
        _weaponCount.Punch(_weapon.Damage2);
    }
    public void Damage3()
    {
        _weaponCount.Punch(_weapon.Damage3);
    }
    public void Damage4()
    {
        _weaponCount.Punch(_weapon.Damage4);
    }
    public void Damage5()
    {
        _weaponCount.Punch(_weapon.Damage5);
    }
    public void Damage6()
    {
        _weaponCount.Punch(_weapon.Damage6);
    }
    public void Damage7()
    {
        _weaponCount.Punch(_weapon.Damage7);
    }
    public void Damage8()
    {
        _weaponCount.Punch(_weapon.Damage8);
    }
    public void Damage9()
    {
        _weaponCount.Punch(_weapon.Damage9);
    }


    public void StartFight()
    {
        StartCoroutine(Fight());

    }

    IEnumerator Fight()
    {
        yield return new WaitForSecondsRealtime(60);
        _panelLose.SetActive(true);
        _attackPanel.SetActive(false);
    }

    private void EndFight()
    {
        _panelWin.SetActive(true);
        _attackPanel.SetActive(false);
    }
}
