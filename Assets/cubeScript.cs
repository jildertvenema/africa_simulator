using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

    public Vector3 posCube;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        posCube = transform.position;

    }
}
