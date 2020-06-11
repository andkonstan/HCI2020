using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip beepSound;
    static AudioSource auidoSrc;

    void Start()
    {
        beepSound = Resources.Load<AudioClip>("beepSound");
        auidoSrc = GetComponent<AudioSource>();
    }

    public static void playSound() {
        auidoSrc.PlayOneShot(beepSound);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
