using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPlayer : MonoBehaviour
{
    [HideInInspector]
    public bool isSeen = false;
    public GameObject Archer;
    Animator ArcherAnim;
    public int damageAmount = 1;
    public GameObject Robin;
   


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.tag == "Player"))
        {
            isSeen = true;
            ArcherAnim = Archer.GetComponent<Animator>();
            ArcherAnim.SetBool("SeenPlayer", isSeen);
            Robin.GetComponent<CharacterController2D>().ApplyDamage(damageAmount);
            
        }
            
    }
   
    

    


}
