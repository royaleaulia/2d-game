using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreCounterAbuAbu : MonoBehaviour
{

    public int countabu;
    // Start is called before the first frame update
    void Start()
    {
        countabu = 0;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Hijau") && this.gameObject.CompareTag("Hijau")) || (other.gameObject.CompareTag("Biru") && this.gameObject.CompareTag("Biru")) || (other.gameObject.CompareTag("Merah") && this.gameObject.CompareTag("Merah")) || (other.gameObject.CompareTag("Kuning") && this.gameObject.CompareTag("Kuning")) | (other.gameObject.CompareTag("Abu") && this.gameObject.CompareTag("Abu")));
        {

            countabu = countabu + 1;
        }
    }

}
