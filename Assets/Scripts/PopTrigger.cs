using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopTrigger : MonoBehaviour {
	
	public MeshRenderer targetMeshRenderer;
	public GameObject targetGameObject;

	public GameObject popcornPrefab;

	void OnTriggerEnter(Collider other) {
		targetMeshRenderer.enabled = true;


		GameObject popcornGameObject = Instantiate(popcornPrefab);
		popcornGameObject.transform.position = other.transform.position;
	
		Destroy(other.gameObject);

		Destroy(targetGameObject);
	}
}