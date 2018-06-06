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
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = data.Color;
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(data.Speed, 0, 0);
    }
}
