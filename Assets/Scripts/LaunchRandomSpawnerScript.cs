using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchRandomSpawnerScript : MonoBehaviour
{
    List<SpawnerBehaviour> spawners;
    public FloatVariable SpawnTime;
    public FloatVariable ResetTime;
    // Use this for initialization
    void Start()
    {
        SpawnTime.Value = ResetTime.Value;
        spawners = new List<SpawnerBehaviour>();
        foreach (var v in FindObjectsOfType<SpawnerBehaviour>())
        {
            spawners.Add(v);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTime.Value -= Time.deltaTime;
        if (SpawnTime.Value <= 0)
        {
            var r = Random.Range(0, spawners.Count - 1);
            spawners[r].LaunchSpawner();
            SpawnTime.Value = ResetTime.Value;    
        }
    }
}
