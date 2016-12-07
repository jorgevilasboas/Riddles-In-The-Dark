using UnityEngine;
using System.Collections;

public class DoorsMove : MonoBehaviour
{
	public float speed = 3f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.x <= -50) {
			transform.position += new Vector3 (40, 0, 0);
		}
		transform.position = transform.position + Vector3.left * speed * Time.deltaTime;	
	}
}
