using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class Chaser : MonoBehaviour {

    private GameObject Player;
    public int speed = 10;

    void Start()
    {
        Player = GameObject.Find("Robin");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }

}
