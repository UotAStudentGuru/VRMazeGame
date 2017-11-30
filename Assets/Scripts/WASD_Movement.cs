using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class WASD_Movement : MonoBehaviour {

 public GameObject ground;
 public float speed = 18;
 private Vector3 spawnPoint;
 private Rigidbody rig;

 // Use this for initialization
 void Start () 
  {
   spawnPoint = transform.position;
   rig = GetComponent<Rigidbody>();
  }
 
 // Update is called once per frame
 void Update ()
 {
  float hAxis = Input.GetAxis("Horizontal");
  float vAxis = Input.GetAxis("Vertical");
  
  Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;
  
  rig.MovePosition(transform.position + movement);

  if (transform.position.y < -10f) {
			transform.position = spawnPoint;
		}

 }
}﻿
