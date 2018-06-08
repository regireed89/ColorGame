﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectObjects : MonoBehaviour
{
    public IntergerVariable Score;
    public GameObject border;
    public GameEvent changeScore;

    public BoolVariable Collect;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (Collect.Value)
                {
                    if (hit.collider.tag.Equals("Collectible") && hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color == border.GetComponent<SpriteRenderer>().color)
                    {
                        hit.collider.gameObject.SetActive(false);
                        changeScore.Raise();
                    }
                    else if (hit.collider.tag.Equals("Collectible") && hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color != border.GetComponent<SpriteRenderer>().color)
                    {
                        SceneManager.LoadScene(0);
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    if (hit.collider.tag.Equals("Collectible") && hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color != border.GetComponent<SpriteRenderer>().color)
                    {
                        hit.collider.gameObject.SetActive(false);
                        changeScore.Raise();
                    }
                    else if (hit.collider.tag.Equals("Collectible") && hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color == border.GetComponent<SpriteRenderer>().color)
                    {
                        SceneManager.LoadScene(0);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
