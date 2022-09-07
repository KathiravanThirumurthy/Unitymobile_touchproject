using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // checking if we touch onscreen
       if(Input.touchCount > 0)
        {// we are not going to check every single touch on the screen instead we loop thrugh 
            // touches are stored in array 
            // all the varous touches in the screen are put in touches array
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                // now we can figure out which object we are touching on the screen
                //giving position of the ray
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hitInfo;
                if(Physics.Raycast(ray,out hitInfo))
                {
                    if(hitInfo.collider !=null)
                    {
                          Color color = new Color(Random.value, Random.value, Random.value);
                          hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                       // hitInfo.collider.gameObject.transform.position = hitInfo.point;
                    }
                }


            }
        }
    }
}
