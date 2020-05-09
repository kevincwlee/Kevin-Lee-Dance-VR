using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScale : MonoBehaviour
{
        void Update()
    {
        float[] spectrum = new float[256];

        AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        for (int i = 1; i < spectrum.Length - 1; i++)
        {
            
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, spectrum[i]*10 + 0.047f, gameObject.transform.localScale.z);
        }
    }
}