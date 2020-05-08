using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : NPCBaseFSM
{

    Vector3 destination;
    public float speed;
    public float acceleration;
    public float angularSpeed;
    public float arriveDistance;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        destination = NPC.spawnArea.GetRandomWaypointPosition();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        movement.SetAgentValues(speed, angularSpeed, acceleration, false);
        if(Vector3.Distance (NPC.transform.position, destination) < arriveDistance) {
            destination = NPC.spawnArea.GetRandomWaypointPosition();
        }
        movement.SetDestination(destination);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
    }
}
