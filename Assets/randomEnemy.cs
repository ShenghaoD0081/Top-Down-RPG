using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int xPos;
    public int yPos;
    public int enemyCount;
    Pathfinding.AIDestinationSetter aiDestination;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab.GetComponent<Pathfinding.AIDestinationSetter>().target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < 30)
        {
            //Spawn Enemy randomly within map
            xPos = Random.Range(-19, 19);
            yPos = Random.Range(-17, 19);
            Instantiate(enemyPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
            
        }
    }
}
