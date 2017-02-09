using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float xdist;
	public float ydist;
	public float zdist;
	public GameObject bacon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (bacon.transform.position.x + xdist, bacon.transform.position.y + 90,bacon.transform.position.z + -295);
	}
}
