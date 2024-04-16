using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingobj : MonoBehaviour
{ MeshRenderer renderer;
  Rigidbody rig;
  
    [SerializeField]float a=5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer=GetComponent<MeshRenderer>();
        renderer.enabled= false;
        rig= GetComponent<Rigidbody>() ; 
        rig.useGravity = false;
    }
  
    // Update is called once per frame
    void Update()
    {
        if (Time.time > a)
        {
            renderer.enabled= true;
            rig.useGravity = true;
        }
    }
}
