using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{

    public Slider EnemySlider;
    public void TakeDamage (float amount)
    {
        EnemySlider.value -= amount ;
        if (EnemySlider.value == 0)
        {
            Die();
        }  
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
