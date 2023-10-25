using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variable defining the bounds of the screen
    private float topBound = 7.11f;
    private float lowerBound = -8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Debug.Log("Game Over !");
            Destroy(gameObject);
        }



    }
}
