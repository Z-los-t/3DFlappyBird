using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerManager : MonoBehaviour
{
    protected int _roadSpeed;
    protected int _cloudSpeed;
    protected int _liveTime;
    public void Initialize(int roadSpeed, int cloudSpeed)
    {
        _roadSpeed = roadSpeed;
        _cloudSpeed = cloudSpeed;
    }
    public abstract void FixedUpdate();
}
