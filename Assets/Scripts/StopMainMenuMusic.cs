using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMainMenuMusic : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("Music1");
        
        
        Destroy(A);
        //you're welcome
    }

}
