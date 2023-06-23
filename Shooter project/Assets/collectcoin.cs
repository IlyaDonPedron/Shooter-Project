using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectcoin : MonoBehaviour
{
    public Text Score;
    public int ScoreValue;


    private void Update()
    {
        transform.Rotate(1,1,1);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            Destroy(this.gameObject);
            ScoreValue ++;
            Score.text = ScoreValue.ToString();

        }
    }
}
