using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject followTarget;
    public float moveSpeed;

	void Start () {
		
	}
	
	void Update () {
        //var rotate = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        Quaternion rotate = followTarget.transform.rotation;

        if (followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.transform.position, Time.deltaTime * moveSpeed);
            transform.rotation = rotate;
        }
	}
}
