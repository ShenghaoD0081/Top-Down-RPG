using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindRadius : MonoBehaviour
{
    // Start is called before the first frame update
    Pathfinding.AIDestinationSetter aiDestination;
    public GameObject player;
    [SerializeField] float distanceFromPlayer; //[SerializeField] means it's still private but you can see it in the game editor.
    public float distance = 5;
    private GameObject enemy;
    Pathfinding.AIPath aiPath;
    void Start()
    {
        aiDestination = this.gameObject.GetComponent<Pathfinding.AIDestinationSetter>();
        aiPath = this.gameObject.GetComponent<Pathfinding.AIPath>();
        enemy = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromPlayer = Vector3.Distance(player.transform.position, enemy.transform.position);
        if(distanceFromPlayer < distance)
        {
            aiDestination.enabled = true;
            aiPath.enabled = true;
        }
        else
        {
            aiDestination.enabled = false;
            aiPath.enabled = false;
        }
    }
}
