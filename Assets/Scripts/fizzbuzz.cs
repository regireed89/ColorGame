using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizzbuzz : MonoBehaviour {

	// Use this for initialization
	void Start () {

        FizzBuzzBoi(100);
	}

    void FizzBuzzBoi(int num)
    {
        for (int i = 0; i == num; i++)
        {
            if (i % 3 == 0)
                Debug.Log("Fizz");
            else if (i % 5 == 0)
                Debug.Log("Buzz");
            else if (i % 3 == 0 && i % 5 == 0)
                Debug.Log("FizzBuzz");
            else
                Debug.Log(i);
        }
    }
}
