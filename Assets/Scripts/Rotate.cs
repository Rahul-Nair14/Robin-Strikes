using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotateSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0f, 90f * Time.deltaTime * rotateSpeed, 0f);
    }
}
