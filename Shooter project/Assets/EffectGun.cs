using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectGun : MonoBehaviour
{

    public GameObject explosion;
    public Transform BurrelEnd;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Boom();
        }
    }

    void Boom()
    {
        GameObject boom=Instantiate(explosion, BurrelEnd);
        Destroy(boom, 0.1f);
    }

}
