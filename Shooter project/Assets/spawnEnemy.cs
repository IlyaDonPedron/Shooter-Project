using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public float Timer;
    public float Mytime;
    public GameObject enemy;
    public float x;
    public float z;



    void Update()
    {
        x = Random.Range(0,200);
        z = Random.Range(0, 200);

        Timer += Time.deltaTime;
        if(Timer > Mytime)
        {
            Instantiate(enemy, new Vector3(x,0,z), transform.rotation);
            Timer = 0;
        }
    }
}
