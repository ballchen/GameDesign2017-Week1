using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {
    public float RotateSpeed;
    private Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        myTransform.Rotate(new Vector3(0, 0, RotateSpeed * Time.deltaTime));
	}
}
