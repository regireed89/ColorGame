using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseBehaviour : MonoBehaviour
{

    public BoolVariable Collect;
    public void OnTriggerExit(Collider other)
    {
        if (Collect.Value)
        {
            if (other.gameObject.GetComponent<CollectibleBehaviour>().data.Color == gameObject.GetComponent<SpriteRenderer>().color)
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (other.gameObject.GetComponent<CollectibleBehaviour>().data.Color != gameObject.GetComponent<SpriteRenderer>().color)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
