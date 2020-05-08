using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBounce : MonoBehaviour
{
    AudioSource AudioDB;
    Transform ObjectScale;


    void Awake()
    {
        AudioDB = GetComponent<AudioSource>();
        ObjectScale = gameObject.GetComponent<Transform>();
        float[] samples = new float[AudioDB.clip.samples * AudioDB.clip.channels];
        AudioDB.clip.GetData(samples, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}