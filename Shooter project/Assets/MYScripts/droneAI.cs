using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class droneAI : MonoBehaviour
{
    Enemy enemy;
    NavMeshAgent drone;
    public GameObject player;
    public float Radius;
    public float Distance;
    public AudioSource Gun;
    
    
    
    
    void Start()
    {
        drone = GetComponent<NavMeshAgent>(); 
    }

    
    void Update()
    {
        
        enemy = FindObjectOfType<Enemy>();
        drone.SetDestination(player.transform.position);
        Distance =Vector3.Distance(transform.position,enemy.transform.position);
        transform.LookAt(enemy.transform.position);
        

        if (Distance < Radius)
        {
            Gun.Play();
            enemy.EnemySlider.value -= 50*Time.deltaTime;
        }
        
    }
}
