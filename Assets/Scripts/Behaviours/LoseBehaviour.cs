using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CollectibleBehaviour>().data.Color == gameObject.GetComponent<SpriteRenderer>().color)
            SceneManager.LoadScene(0);

    }
}
