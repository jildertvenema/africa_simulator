using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class cubeBehave : MonoBehaviour {

    bool poep = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        System.Random rnd = new System.Random();
        int i = rnd.Next(0, 3);
        switch (i)
        {
            case 0:
                Vector3 p = transform.localScale;
                p.y += .5f;
                transform.localScale = p;
                break;
            case 1:
                Vector3 p2 = transform.position;
                p2.y += 3;
                transform.position = p2;
                break;
            case 2:
                transform.up = transform.up + transform.up;
                break;
            default:
                Vector3 p1 = transform.localScale;
                p1.y += .5f;
                transform.localScale = p1;
                break;
        }

        if (!poep)
        {
            GameObject.Find("dialog1").GetComponent<Text>().text = "40 graden";
            poep = true;
        }
        else
        {
            GameObject.Find("dialog1").GetComponent<Text>().text = " ";
            poep = false;
        }
    }
}
