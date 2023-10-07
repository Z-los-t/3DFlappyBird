using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : SpawnerManager
{
    public override void FixedUpdate()
    {
        transform.Translate(-transform.right * _roadSpeed * Time.fixedDeltaTime);
    }
    private void Start()
    {
        Destroy(gameObject, _liveTime);
    }
}
