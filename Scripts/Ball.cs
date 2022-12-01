using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour //Ball is child of MonoBehaviour
{
    //create instance of _audioClip:
    public AudioClip _audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //overwrite inherited monobehavious ObCollisionEnter2D object function to play audio clip:
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(_audioClip, transform.position);
        //AudioSource is a class because object static
    }
}
