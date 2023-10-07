using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : SpawnerManager
{
    public override void FixedUpdate()
    {
        transform.Translate(-transform.right * _cloudSpeed * Time.fixedDeltaTime);
    }
    private void Start()
    {
        Destroy(gameObject, _liveTime);
    }
}
