using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMotionColor : MonoBehaviour
{
    Material HandColor;
    Transform HandPos;
    void Awake()
    {
        HandColor = GetComponent<MeshRenderer>().material;
        HandPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EulerAngles: " + HandPos.rotation.eulerAngles);
        Vector3 rot = HandPos.rotation.eulerAngles;
        HandColor.color = new Color((rot.x % 360) / 360, (rot.y % 360) / 360, (rot.z % 360) / 360);

    }
}
