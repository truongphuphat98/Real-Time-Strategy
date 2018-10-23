using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {

	void Start() {
		GetComponent<Renderer>().material.color = Color.red;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "RTS Selection") {
			GetComponent<Renderer>().material.color = Color.green;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.name == "RTS Selection") {
			GetComponent<Renderer>().material.color = Color.red;
		}
	}

}
