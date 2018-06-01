using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
{

    public CollectibleData data;

    private void OnEnable()
    {
        data = ScriptableObject.CreateInstance<CollectibleData>();
    }
    // Use this for initialization
    void Start()
    {
        GetComponentInChildren<SpriteRenderer>().material.color = data.Color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.TransformDirection(new Vector3(2 * Time.deltaTime, 0, 0));
    }
}
