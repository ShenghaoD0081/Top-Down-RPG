using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collide)
    {
        if(collide.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

//if (collide.CompareTag("Player") && !collide.isTrigger)
//{
    //SceneManager.LoadScene(sceneToLoad);
//}