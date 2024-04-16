using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
 [SerializeField]float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
     Instructions();   
     
    }

    // Update is called once per frame
    void Update()
    {
    Movement();  
    }
    void Instructions()
    {
        Debug.Log("welcome to the game");
        Debug.Log("use W A S D to move Front Left Back and Right respectively");
        Debug.Log("try not hit walls and the object");
    }

    void Movement()
    {
      float xm = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zm = Input.GetAxis("Vertical") * Time.deltaTime * movespeed; 
        transform.Translate(xm,0,zm);

    }

}
