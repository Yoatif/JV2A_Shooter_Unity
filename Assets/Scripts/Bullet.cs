using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ScorePlayer scorePl;
    public Rigidbody2D monRigidBody;
    //public Rigidbody2D mySecondRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        scorePl = FindObjectOfType<ScorePlayer>();      
        monRigidBody.velocity = transform.up *speed;
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ReplacementOnDestroy enemi = collision.gameObject.GetComponent  <ReplacementOnDestroy>();
        if (enemi ==true)
        {
            enemi.MAchinTrucs();
            Destroy(collision.gameObject);
            scorePl.addScore(1);
            Destroy(gameObject);
        }

    }

}
