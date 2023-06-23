using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{

    public float Timer;
    public float MyTime;
    public GameObject coin;
    public float x;
    public float y=36;
    public float z;
    
    void Update()
    {

        x = Random.Range(-109,-5);
        z = Random.Range(-6000, 25000);

        Timer += Time.deltaTime;
        
        if (Timer > MyTime)
        {
            Instantiate(coin,new Vector3(x,y,z),transform.rotation);
            Timer = 0;
        }
    }
}
