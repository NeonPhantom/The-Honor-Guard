using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 50.0f;
    public bool isJumping = false;
    public bool isFalling = false;
    //public 

	void Start () {
        
    }
	
	void Update () {
        
        var rotate = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var forward = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var jump = Input.GetAxis("Jump") * Time.deltaTime * 60.0f;

        transform.Rotate(0, rotate, 0);
        transform.Translate(0, jump, 0);
        transform.Translate(-forward, 0, 0);

        
    }

   
}
