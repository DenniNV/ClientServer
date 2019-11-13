using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newBoss", menuName = "Boss")]
public class Bosses : ScriptableObject
{
    public string Name;
    public float Hp;
    public int RewardGoldTooth;
    public int RewardExp;
    public int RandomReward;
    public Sprite Image;
}
