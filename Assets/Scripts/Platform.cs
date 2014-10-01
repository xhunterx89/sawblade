using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float speed = 2;

	void Update () {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
		if (transform.position.x > 100 || transform.position.x< -100) {
			this.speed=-this.speed;		
		}
	}
}
