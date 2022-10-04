using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public float speed;
    public float maxspeed;
    public Nyawa nyawa;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once pedfar frame
    void Update()
    {

        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        if (speed < maxspeed)
        {
            speed += 0.001f * Time.deltaTime;
        }




    }
}
