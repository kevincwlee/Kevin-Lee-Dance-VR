using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFilter : MonoBehaviour
{
    Transform HeadTransform;
    AudioLowPassFilter AudioFilter;

    // Start is called before the first frame update
    void Start()
    {
        HeadTransform = gameObject.transform;
        AudioFilter = gameObject.GetComponent<AudioLowPassFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("x: " + HeadTransform.rotation.x + " y: " + HeadTransform.rotation.y + " z: " + HeadTransform.rotation.z + " filter: " + AudioFilter.cutoffFrequency);
        AudioFilter.cutoffFrequency = (11000*(HeadTransform.rotation.x + 1)/2);
    }
}
