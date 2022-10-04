using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounterBlue : MonoBehaviour
{
    // Start is called before the first frame update
    public Draggable draggable;

    public int countblue;


    void Start()
    {
        countblue = 0;
/*        SetCountText();*/
    }


    // Update is called once per frame
    /*    void SetCountText()
        {
            countText.text = "Count: " + count.ToString();

        }*/

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Hijau") && this.gameObject.CompareTag("Hijau")) || (other.gameObject.CompareTag("Biru") && this.gameObject.CompareTag("Biru")) || (other.gameObject.CompareTag("Merah") && this.gameObject.CompareTag("Merah")) || (other.gameObject.CompareTag("Kuning") && this.gameObject.CompareTag("Kuning")) | (other.gameObject.CompareTag("Abu") && this.gameObject.CompareTag("Abu")))
        {
            countblue = countblue + 1;

        }
        /*        SetCountText();*/
    }



}

