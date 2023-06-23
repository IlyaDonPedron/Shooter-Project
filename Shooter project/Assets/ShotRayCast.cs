using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShotRayCast : MonoBehaviour
{
   
    public Camera fpsCam;
    public float range ;
    public float damage;
    
   

    
    void Update()

    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            
            Shot();
        }
    }
    void Shot()
    {
        RaycastHit hitinfo;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitinfo,range))
        {
            Debug.Log(hitinfo.transform.name);

            Target target = hitinfo.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

    
}
