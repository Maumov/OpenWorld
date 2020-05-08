using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float baseMovementSpeed;
    public float baseAngularSpeed;
    public float baseAcceleration;
    public float baseStoppingDistance;
    public bool baseIsStopped;
    //NavMeshPath path;
    NavMeshAgent agent;
    Stats stats;

    private void Start() {
        stats = GetComponent<Stats>();
        agent = GetComponent<NavMeshAgent>();
        GetComponent<Stats>().OnDead += Dead;
    }

    private void Update() {
        if(!stats.isAlive) {
            return;
        }
        if((stats.status & StatusEffect.Stunned) != 0 ||  ((stats.status & StatusEffect.Frozen) != 0)) {
            agent.speed = 0f;
            agent.isStopped = true;
        } else if((stats.status & StatusEffect.Injured) != 0) {
            agent.speed = baseMovementSpeed * 0.5f;
        }else {
            agent.speed = baseMovementSpeed + stats.currentMovement;
            agent.isStopped = baseIsStopped;
        }
    }


    public void SetDestination(Vector3 position) {
        if(!stats.isAlive) {
            return;
        }
        agent.SetDestination(position);
    }

    public void SetAgentValues( float speed, float angularSpeed, float acceleration, float stoppingDistance, bool isStopped) {
        SetAgentValues(speed, angularSpeed, acceleration);
        SetAgentValues(stoppingDistance);
        SetAgentValues(isStopped);
    }

    public void SetAgentValues(float speed, float angularSpeed, float acceleration, bool isStopped) {
        SetAgentValues(speed, angularSpeed, acceleration);
        SetAgentValues(isStopped);
    }
    public void SetAgentValues(float speed, float angularSpeed, float acceleration) {
        baseMovementSpeed = speed;
        agent.angularSpeed = angularSpeed;
        agent.acceleration = acceleration;
    }
    public void SetAgentValues(float stoppingDistance) {
        agent.stoppingDistance = stoppingDistance;
    }
    public void SetAgentValues(bool value) {
        baseIsStopped = value;    
    }
    public void HitKickBack() {
        if(agent.enabled) {
            agent.Move(-transform.forward * 0.35f);
        }
    }
    public void Dead() {
        agent.isStopped = true;
        agent.enabled = false;
    }
}
