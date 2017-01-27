using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour
{

    public Vector3 bodyX;
    public Vector3 camX;
    public GameObject cam;
    public GameObject body;
    public float hoofd;

    void Update()
    {
        camX.x = -Input.GetAxis("Mouse Y");
        {
            cam.transform.Rotate(camX);
        }
        bodyX.y = Input.GetAxis("Mouse X");
        {
            body.transform.Rotate(bodyX);
        }

        //hoofd = Mathf.Clamp(hoofd, -30, 90);
        //transform.position = hoofd (Mathf.Clamp)
    }
        
}

