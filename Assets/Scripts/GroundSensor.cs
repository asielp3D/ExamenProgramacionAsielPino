using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private Mario mario;
    public bool groundsensor;

   void Awake() 
   {
   
   }

   void OnTriggerStay2D(Collider2D other) 
   {
    if(other.gameObject.layer ==3)
    {
        groundsensor = true;
    }
   }

    void OnTriggerExit2D(Collider2D other) 
   {
    if(other.gameObject.layer ==3)
    {
        groundsensor = false;
    }
   }
}
