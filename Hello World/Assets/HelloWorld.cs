using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	public string myName = "Jordan";
	public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject go =	Instantiate<GameObject> (cubePrefab);
		go.transform.position = Random.insideUnitSphere;
		go.transform.rotation = Random.rotation;

		Renderer rend = go.GetComponent<Renderer> ();
		Material mat = rend.material;
		mat.color = new Color (Random.value, Random.value, Random.value);
	}
}
