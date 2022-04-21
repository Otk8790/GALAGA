using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();

		rb.position = new Vector3(transform.position.x, 1f, transform.position.z);
		rb.velocity = transform.forward * speed;
	}
}
