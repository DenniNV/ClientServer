using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UpdatesInstaller : MonoInstaller
{

    public UpdateSilver UpdateSilver;
    public UpdateLevel UpdateLevel;
    public UpdateGoldCoins GoldCoins;
    public UpdateBossKill BossKill;
    public UpdateGooldTooth GooldTooth;
    public override void InstallBindings()
    {
        Container.BindInstance(UpdateLevel).AsSingle();
        Container.BindInstance(UpdateSilver).AsSingle();
        Container.BindInstance(GoldCoins).AsSingle();
        Container.BindInstance(BossKill).AsSingle();
        Container.BindInstance(GooldTooth).AsSingle();

    }

}
