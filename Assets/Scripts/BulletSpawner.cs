using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed = 10f;
    public float interval = 1f;
    public GameObject Ogre;
    
    

    void Start()
    {
        
        InvokeRepeating("SpawnNext", 1f, interval);

    }
    
    public void SpawnNext()

    {
        GameObject newBullet;
        newBullet = Instantiate(Bullet);
        newBullet.transform.parent = this.gameObject.transform;
        newBullet.transform.position = this.gameObject.transform.position;

        if (Ogre.GetComponent<Transform>().localScale.x > 0)
        {

            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * BulletSpeed);
        }
        if (Ogre.GetComponent<Transform>().localScale.x < 0)
        {

            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * BulletSpeed);
        }

    }

}
