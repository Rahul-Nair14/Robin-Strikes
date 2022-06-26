using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLives : MonoBehaviour
{
    public int LifeValue = 1;
    public bool taken = false;
    public GameObject explosion;
    public GameObject GM;
    public AudioClip noise;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if ((other.tag == "Player") && (!taken) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
        {
            // mark as taken so doesn't get taken multiple times
            taken = true;
            other.GetComponent<CharacterController2D>().PlaySound(noise);
            

            
            
            // if explosion prefab is provide, then instantiate it
            if (explosion)
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }

            GM.GetComponent<GameManager>().lives += LifeValue;
            GM.GetComponent<GameManager>().UIExtraLives.text = "Lives: " + GM.GetComponent<GameManager>().lives.ToString();


            Object.Destroy(this.gameObject);

        }
    }


}

