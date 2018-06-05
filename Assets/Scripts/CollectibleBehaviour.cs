using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
{

    public CollectibleData data;

    private void OnEnable()
    {
       // data = ScriptableObject.CreateInstance<CollectibleData>();
    }
    // Use this for initialization
    void Start()
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = data.Color;
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(data.speed.Value, 0, 0, Space.Self);
    }
}
