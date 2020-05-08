using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionColor : MonoBehaviour
{
    Material CubeColor;
    Transform HeadCam;


    void Awake()
    {
        CubeColor = GetComponent<MeshRenderer>().material;
        HeadCam = GameObject.FindGameObjectWithTag ("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EulerAngles: " + HeadCam.rotation.eulerAngles);
        Vector3 rot = HeadCam.rotation.eulerAngles;
        CubeColor.color = new Color(rot.x/10, rot.y/10, rot.z/10);
        
    }
}
