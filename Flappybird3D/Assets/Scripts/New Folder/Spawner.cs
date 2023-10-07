using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private int roadSpeed, cloudSpeed;
    private void Spawn(SpawnerManager spawnermanager)
    {
        SpawnerManager instance = Instantiate(spawnermanager);
    }
}
