using UnityEngine;
using System.Collections;

public class plaatsjemoetwelbljiven : MonoBehaviour {


	void Start ()
    {
        //vextor = GameObject.Find("Cube").transform.position;
        //transform.position = vextor;
    }
	

	void Update ()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(GameObject.Find("Cube").transform.position);
        screenPos.y += 70;
        transform.position = (screenPos);
    }
}
