using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounterYellow : MonoBehaviour
{


    public int countyellow;

    // Start is called before the first frame update
    void Start()
    {
        countyellow = 0;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
      if ((other.gameObject.CompareTag("Hijau") && this.gameObject.CompareTag("Hijau")) || (other.gameObject.CompareTag("Biru") && this.gameObject.CompareTag("Biru")) || (other.gameObject.CompareTag("Merah") && this.gameObject.CompareTag("Merah")) || (other.gameObject.CompareTag("Kuning") && this.gameObject.CompareTag("Kuning")) | (other.gameObject.CompareTag("Abu") && this.gameObject.CompareTag("Abu")))
        {
            countyellow = countyellow + 1;

        }
        /*        SetCountText();*/
    }
}
