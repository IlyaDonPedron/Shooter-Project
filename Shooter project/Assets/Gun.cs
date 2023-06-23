using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public GameObject bulletclone;
    public Transform burrelEnd;
    public GameObject explosion;
    public AudioSource Audio;
    

    

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
            Audio.Play();
            bulletclone =Instantiate(bullet, burrelEnd.transform.position, transform.rotation);
            bulletclone.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*speed);
            Destroy(bulletclone,2);

        }


    }

    void Shot()
    {
        GameObject shot = Instantiate(explosion, burrelEnd.transform.position, transform.rotation);
        Destroy(shot,0.1f);
        
    }
}
