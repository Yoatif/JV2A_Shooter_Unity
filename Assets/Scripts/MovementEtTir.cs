    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public ScorePlayer scorePl;
    public ShootingType shootType;
    public int scoreToEUnlockShoot = 20;
    //public int scoreToEnableTripleBullet = 100;

    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        scorePl = FindObjectOfType<ScorePlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tirer();
            Debug.Log("je tir");
        }

        if (scorePl.playerScore > scoreToEUnlockShoot)
        {
            
            shootType = ShootingType.DoubleBullet;
        }

        if (scorePl.playerScore > 100)
        {

            shootType = ShootingType.TripleBullet;
        }
        if(scorePl.playerScore < scoreToEUnlockShoot) {
            shootType = ShootingType.SimpleBullet;
        
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }

    public void Tirer()
    {
        switch (shootType)
        {
            case ShootingType.DoubleBullet:
                DoubleBullet();
                break;
            case ShootingType.TripleBullet:
                TripleBullet();
                break;
            default:
                SimpleBullet();
                break;
        }
    }
    public void SimpleBullet()
    {
        Instantiate(bullet, parent.position, parent.rotation);
    }

    public void DoubleBullet()
    {
        Instantiate(bullet, parent.position - parent.right * 0.5f, parent.rotation);
        Instantiate(bullet, parent.position + parent.right * 0.5f, parent.rotation);

    }

    public void TripleBullet()
    {
        Instantiate(bullet, parent.position, parent.rotation);
        Instantiate(bullet, parent.position, Quaternion.Euler(0f,0f,45f));
        Instantiate(bullet, parent.position, Quaternion.Euler(0f, 0f, -45f));

    }
    public enum ShootingType
    {
        SimpleBullet,
        DoubleBullet,
        TripleBullet,
    }





}
