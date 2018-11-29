using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

	bool started = true;
	Rigidbody rb;

	Vector3 offset;
	float newY;

	float initialY;
	float finalY;


	void Start ()
	{

		started = false;
		rb = GetComponent<Rigidbody> ();
	

	}

	// Update is called once per frame
	void Update ()
	{
		//		initialY = transform.position.y;
		//		print ("initialY" + initialY);
		if (Input.touchCount != 0) {
			started = true;

			if (started) {

				rb.useGravity = true;

				//				HurdleManager.instance.Cam.transform.position = 



				Touch touch = Input.GetTouch (0);
				//				rb.useGravity = false;
				print (touch.position);

				if (touch.position.x < Screen.width / 2 && Input.GetTouch (0).phase == TouchPhase.Ended) {
					rb.velocity = Quaternion.Euler (0, 0, 15) * transform.up * 5;
					started = true;
				} else if (touch.position.x > Screen.width / 2 && Input.GetTouch (0).phase == TouchPhase.Ended) {
					rb.velocity = Quaternion.Euler (0, 0, -15) * transform.up * 5;
					started = true;
				}
			}
		}

	}

	void LateUpdate(){
		//		finalY= transform.position.y;
		//		print ("finalY" + finalY);
		//		if (finalY > initialY) {
		newY = transform.position.y + offset.y;

		//		}

	}


	void OnCollisionEnter (Collision col)
	{
		started = false;
		print ("INN");

	}
}

