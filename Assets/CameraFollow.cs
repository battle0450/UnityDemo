using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    Transform Pos;
    public float xOffset = 1.8f;
	// Use this for initialization
	void Start () {
        Pos = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 followPos = new Vector3(target.position.x + xOffset, Pos.position.y, Pos.position.z);
        Pos.position = followPos;
	}
}
