using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    int hits = 0;

   private void OnCollisionEnter(Collision other) 
    
   {
      if (other.gameObject.tag!="Hit")
      {
         
      
       hits=hits + 1;
        Debug.Log("You'have collided to other object this many times: " + hits);   
      }
   }
   

   
   
}
