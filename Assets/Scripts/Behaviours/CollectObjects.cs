using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjects : MonoBehaviour
{
    public IntergerVariable Score;
    public GameObject border;
    public GameEvent changeScore;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.collider.tag == "Collectible" && hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color == border.GetComponent<SpriteRenderer>().color)
                {
                    hit.collider.gameObject.SetActive(false);
                    changeScore.Raise();
                }
                else if (hit.collider.gameObject.GetComponent<CollectibleBehaviour>().data.Color != border.GetComponent<SpriteRenderer>().color)
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}
