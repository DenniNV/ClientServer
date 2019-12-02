using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewWeaponCount : MonoBehaviour
{
    private LoadWeaponCount _weaponCount = new LoadWeaponCount();
    [SerializeField]
    private GameObject _attackPanel;
    public GameObject AttackPanel { set => _attackPanel = gameObject; get => _attackPanel; }
    [SerializeField]
    private Text _countFirstWeapon;
    [SerializeField]
    private Text _countSecondWeapon;
    [SerializeField]
    private Text _countThreeWeapon;
    [SerializeField]
    private Text _countFourWeapon;
    [SerializeField]
    private Text _countFiveWeapon;

    private void Start()
    {
             Load();
            _countFirstWeapon.text = PlayerPrefs.GetString("Weapon" + 0);
            _countSecondWeapon.text = PlayerPrefs.GetString("Weapon" + 1);
            _countThreeWeapon.text= PlayerPrefs.GetString("Weapon" + 2);
            _countFourWeapon.text = PlayerPrefs.GetString("Weapon" + 3);
        _countFiveWeapon.text = PlayerPrefs.GetString("Weapon" + 4);
    }
    private void Load()
    {
        StartCoroutine(_weaponCount.LoadData(PlayerPrefs.GetString("UserLogin"), "Weapon"));
    }
    
    
    
    //TODO Вынести последующий код в новый класс
    [SerializeField]
    private Text _hp;
    public Text Hp { get => _hp; }
    [SerializeField]
    private Image _bossImage;
    [SerializeField]
    private Text _bossName;
    [SerializeField]
    private Text _rewardExp;
    [SerializeField]
    private Text _rewardGoldTooth;
    [SerializeField]
    private Text _rewardGoldCoin;



    
    
    public void LoadImage(LoadBossGameData loadBoss)
    {
        _bossImage.sprite = loadBoss.BossImage();

        _hp.text = loadBoss.Hp;
        _bossName.text = loadBoss.BossName.text;
        _attackPanel.SetActive(true);
        _rewardExp.text = loadBoss.Exp.ToString();
        _rewardGoldTooth.text = loadBoss.GoldTooth.ToString();
        _rewardGoldCoin.text = loadBoss.GoldCoin.ToString();
    }

    public void Punch(int damage)
    {
        int Hp = Convert.ToInt32(_hp.text);
        _hp.text  = (Hp - damage).ToString();
    }

}
