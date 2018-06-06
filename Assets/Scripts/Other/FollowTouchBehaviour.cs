using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouchBehaviour : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float S = Speed * Time.deltaTime;
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, pos, S);
        }
    }
}