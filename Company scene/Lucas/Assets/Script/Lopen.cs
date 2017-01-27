using UnityEngine;
using System.Collections;

public class Lopen : MonoBehaviour {

    public Vector3 v3;
    public float hor;
    public float ver;
    public float speed;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v3.z = ver;
        v3.x = hor;
        

        transform.Translate(v3*Time.deltaTime*speed);
	
	}
}
