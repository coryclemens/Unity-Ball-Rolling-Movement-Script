using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public Vector3 camOffset;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + camOffset;


     

    }
}
