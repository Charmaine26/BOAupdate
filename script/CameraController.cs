using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;

	public Vector3 offset;


	public float pitch = 2f;

	private float yawSpeed = 100f;
	private float currentYaw = 0f;
	public float currentZoom = 10f;

	public float zoomSpeed = 4f;
	public float maxZoom = 15f;
	public float minZoom = 5f;
	float targetZoom;
	 

	

	void Start() {
		
		transform.LookAt (target);
		targetZoom = currentZoom;
	}

	void Update ()
	{
		currentZoom -= Input.GetAxisRaw("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp (currentZoom, minZoom, maxZoom);

		currentYaw += Input.GetAxisRaw("Horizontal") * yawSpeed * Time.deltaTime;
	}




	void LateUpdate () {
		transform.position = target.position - offset * currentZoom;
		transform.LookAt(target.position + Vector3.up * pitch) ;
	}

}

