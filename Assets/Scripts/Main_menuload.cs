using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menuload : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
