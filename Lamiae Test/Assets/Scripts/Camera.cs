using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   public static Transform camerafollow ;
    // Start is called before the first frame update
    void Start()
    {
        //player = Guid.l[0].transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        
         transform.position=new Vector3(transform.position.x,transform.position.y, camerafollow.position.z-17.96f);
    }
}
