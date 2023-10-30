using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 0.09f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.down * Time.deltaTime * speed);
        Vector3 deplacement = new Vector3(0, (speed * Time.deltaTime)*-1, 0);

        // Appliquez le déplacement à l'objet en utilisant la 2D Transform.
        transform.Translate(deplacement);
    }
}
