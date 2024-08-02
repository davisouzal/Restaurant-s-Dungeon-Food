using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Slime : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    private Player player;
    [SerializeField] private AnimateControl animControl;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);

        if(Vector2.Distance(transform.position, player.transform.position) <= agent.stoppingDistance)
        {
            animControl.PlayAnim(2);
        }
        else
        {
            animControl.PlayAnim(1);
        }

        float posX= player.transform.position.x - transform.position.x;
        if(posX > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}
