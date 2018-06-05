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
        var r = Random.Range(0, color.colors.Count - 1);
        go.GetComponent<CollectibleBehaviour>().data.Color = color.colors[r];
    }

}
