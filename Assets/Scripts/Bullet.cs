using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ScorePlayer scorePl;
    public Rigidbody2D monRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        scorePl = FindObjectOfType<ScorePlayer>();      
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        collision.gameObject.GetComponent  <ReplacementOnDestroy>().MAchinTrucs();
        scorePl.addScore(1);

        Destroy(gameObject);
    }

}
