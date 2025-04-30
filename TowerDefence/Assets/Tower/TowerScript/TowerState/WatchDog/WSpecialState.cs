using UnityEngine;

public class WSpecialState : TSpecialState
{
    protected WatchDog watchDog => tower as WatchDog;
    public WSpecialState(Tower tower, TowerFSM towerFSM, string stateName) : base(tower, towerFSM, stateName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        if (triggerCalled2)
        {
            watchDog.CreateWave(watchDog.pos.transform.position,tower.nearestREnemy.transform.position);
            triggerCalled2 = false;
        }
    }
    public override void Exit()
    {
        base.Exit();
    }

}
