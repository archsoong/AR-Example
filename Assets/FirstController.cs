using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstController : MonoBehaviour {
    float rotateSpeed=2f;
    float moveSpeed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0,rotateSpeed*Input.GetAxis("Horizontal"), 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, moveSpeed * Input.GetAxis("Vertical"));
        }
    }
}
