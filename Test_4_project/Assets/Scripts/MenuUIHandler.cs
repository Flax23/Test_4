using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Startgame()
    {
        SceneManager.LoadScene(2);
    }
}
