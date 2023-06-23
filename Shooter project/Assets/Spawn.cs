using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject house;
    public GameObject OldHouse;
    public GameObject well;
    public GameObject bighouse;
    public float x;
    public float z;
    public float x1;
    public float z1;
    public float x2;
    public float z2;
    public float x3;
    public float z3;
    public int create_house;
    
    
   
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            x = Random.Range(0, 200);
            z = Random.Range(0, 200);

            x1 = Random.Range(0, 200);
            z1 = Random.Range(0, 200);

            x2 = Random.Range(0, 200);
            z2 = Random.Range(0, 200);

            x3 = Random.Range(0, 200);
            z3 = Random.Range(0, 200);

            Instantiate(house, new Vector3(x, 0, z),transform.rotation);
            Instantiate(OldHouse, new Vector3(x1, 0, z1), transform.rotation);
            Instantiate(well, new Vector3(x2, 0, z2), transform.rotation);
            Instantiate(bighouse, new Vector3(x3, 0, z3), transform.rotation);

            create_house += 4;
            print(create_house);


            


         
       


        




        }
        
    }
}
