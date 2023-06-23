using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    FirstPersonMovement player;
    NavMeshAgent enemy;
    public Slider EnemySlider;
    
    
   
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();   
        player=FindObjectOfType<FirstPersonMovement>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        enemy.SetDestination(player.transform.position);
        transform.LookAt(player.transform.position);    

        

        if (EnemySlider.value == 0)
        {
            Destroy(this.gameObject);
        }
      


    }

   






}
