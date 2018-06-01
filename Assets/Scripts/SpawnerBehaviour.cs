using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{

    public GameObject prefab;
    public float spawnTime;
    public bool canSpawn;
    private Colors color;
    // Use this for initialization
    void Start()
    {
        canSpawn = false;
        color = FindObjectOfType<Colors>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            var go = GameObject.Instantiate(prefab);
            var r = Random.Range(0, color.colors.Count - 1);
            go.GetComponent<CollectibleBehaviour>().data.Color = color.colors[r];
            Debug.Log("rippy");
        }


    }



}
