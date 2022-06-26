using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{

    public GameObject Ogre;
    public int damageAmount = 1;
    public AudioClip attack;
    
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
        Enemy enemy = Ogre.GetComponent<Enemy>();

        if (player.playerCanMove)
            if ((collision.tag == "Player") && !enemy.isStunned)
            {
                player.PlaySound(attack);
                player.ApplyDamage(damageAmount);
                Object.Destroy(this.gameObject);
            
            
        }
    }
    
}
