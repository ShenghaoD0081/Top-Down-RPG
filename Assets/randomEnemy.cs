using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < 30)
        {
            //Spawn Enemy randomly within map

        }
    }
}
