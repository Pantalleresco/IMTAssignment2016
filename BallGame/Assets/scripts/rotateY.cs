﻿using UnityEngine;
using System.Collections;

public class rotateY : MonoBehaviour {

	void Update () {
		transform.Rotate(new Vector3(30,30,0) * Time.deltaTime);
		
	}
}