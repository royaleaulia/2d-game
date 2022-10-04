using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public GameObject tempatSampah;
    public GameObject batasmerah;
    private bool isDragged = false;
    public bool isupmousecanaddscore = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
    private Vector3 posisisblmdrag;
    private float speed;
    private Vector3 objek;
 

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
        posisisblmdrag = transform.localPosition;
        


}

 

    private void OnMouseDrag()
    {
        if (isDragged)
        {

            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
            

        }
    }


    private void OnMouseUp()
    {
        isDragged = false;
        
    }



    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.Equals(tempatSampah) && isDragged == false)
        {
            Destroy(gameObject);
            isupmousecanaddscore = true;
        }

        if (collision.gameObject.Equals(batasmerah))
        {
            Destroy(gameObject);
        }
        


    }
}
