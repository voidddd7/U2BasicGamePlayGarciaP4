using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float topBound = 30;
    private float lowerBound = -10;
    void Update()
    {
        // If a object goes past the player view in the game, remove the object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }  else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
