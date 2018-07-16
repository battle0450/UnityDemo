using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_csript : MonoBehaviour {

    public Transform trackingTarget;
    float xOffset;
    float yOffset = 4.85f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(trackingTarget.position.x + xOffset, trackingTarget.position.y + yOffset, transform.position.z);
    }
}
