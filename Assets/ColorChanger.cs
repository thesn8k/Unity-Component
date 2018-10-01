using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public SpriteRenderer rend;
    public Color color;

	// Use this for initialization
	void Start ()
    {
        rend.color = color;
        rend.color = new Color(1, 0.25f, 0, 33f);

        transform.position = new Vector3(-5, transform.position.y);

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 360 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) { 
        transform.Rotate(0, 0, -360 * Time.deltaTime);
    }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(2f * Time.deltaTime, 0, 0, Space);
        }

        transform.Translate(0, 0, 0);




    }
        
}
