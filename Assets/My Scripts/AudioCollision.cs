using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour

{

    [SerializeField]
    private AudioClip[] _audioClip;
    private AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            _audioSource.Play();
        }
    }
}