using UnityEngine;
using UnityEngine.AI;


public class AgentControl : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float visionArea = 5f;
    float distance;
    bool follow = false;

    
    NavMeshAgent agent;
    [SerializeField] Transform[] path;
    int goal = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = path[goal].position;

        
        
    }

    

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= visionArea) {
            follow = true;
            agent.speed = 3f;
            agent.destination = player.transform.position;
        } else {
            follow = false;
            agent.destination = path[goal].position;
        }


        if (agent.remainingDistance < 1 && follow == false){
            goal++;
            if (goal == path.Length) {
                goal = 0;
            }
            agent.destination = path[goal].position;


        }
        
    }
}