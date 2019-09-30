using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour
{
    
    public AudioClip disparoplayer;

    AudioSource fuenteaudio;
    // Start is called before the first frame update
    void Start()
    {
        fuenteaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            fuenteaudio.clip = disparoplayer;
            fuenteaudio.Play();
        }
    }
}
