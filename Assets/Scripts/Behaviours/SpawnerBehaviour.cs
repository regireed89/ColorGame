using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject prefab;
    private Colors color;

    // Use this for initialization
    void Start()
    {
        color = FindObjectOfType<Colors>();
    }

    public void LaunchSpawner()
    {
        var go = GameObject.Instantiate(prefab, transform, false);
        var rColor = Random.Range(0, color.colors.Count);
        go.GetComponent<CollectibleBehaviour>().data.Color = color.colors[rColor];
        var rSpeed = Random.Range(0.05f, 0.1f);
        go.GetComponent<CollectibleBehaviour>().data.Speed = rSpeed;
    }
}
