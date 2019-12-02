using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public ViewWeaponCount weaponCount;

    public override void InstallBindings()
    {
        Container.BindInstance(weaponCount).AsSingle();
    }
}