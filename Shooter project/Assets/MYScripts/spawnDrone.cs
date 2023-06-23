using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDrone : MonoBehaviour
{
    public GameObject enemy;
    public float Timer;
    public float time;



    void Update()
    {
        Timer+=Time.deltaTime;
        if (Timer>time)
        {
            Instantiate(enemy);
            Timer = 0;
        }
    }
}
