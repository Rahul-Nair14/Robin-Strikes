using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music1");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        

        DontDestroyOnLoad(this.gameObject);
        
    }



}
