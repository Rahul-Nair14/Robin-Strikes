using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{

    public GameObject Ogre;
    public GameObject Robin;
    float _vx = 0f;
    public int speed = 10;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Ogre.GetComponent<Enemy>().isStunned == false)
        {
            
            Ogre.GetComponent<Enemy>().Flip(_vx);
            Ogre.GetComponent<Animator>().SetBool("Moving", true);
            Ogre.GetComponent<Transform>().position = Vector2.MoveTowards(Ogre.GetComponent<Transform>().position, Robin.GetComponent<Transform>().position, speed * Time.deltaTime);

        }
    }
}
