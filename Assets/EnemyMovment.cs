using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovment : MonoBehaviour
{
    /// Place all waypoints inside array 
    [SerializeField] private Transform[] waypoints;
    private NavMeshAgent enemy;
    private int waypointInedx;
    [SerializeField] private GameObject player;
    private Renderer E;

    private bool onSight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onSight = true;
            Debug.Log("Plaer on sight:  " + onSight);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        onSight = false;
        Debug.Log("Plaer on sight:  " + onSight);
    }

    private void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        E = GetComponent<Renderer>();
        

    }
    private void Update()
    {
        if (onSight)
        {
            Chase();
           
        }else
        {
            Patrol();
        }
            
    }

    private void Chase()
    {

        E.material.SetColor("_Color", Color.red);
        enemy.SetDestination(player.transform.position);
        
    }

    private void Patrol()
    {
        E.material.SetColor("_Color", Color.blue);

        if (enemy.remainingDistance <= .5f)
        {
            waypointInedx = Random.Range(0, waypoints.Length);
            enemy.SetDestination(waypoints[waypointInedx].position);

        }
    }

}
