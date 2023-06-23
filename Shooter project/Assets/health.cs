using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    
    public Slider playerSlider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            playerSlider.value -= 24;
            
        }
    }
}
