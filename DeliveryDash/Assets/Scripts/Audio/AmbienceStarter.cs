using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceStarter : MonoBehaviour
{
    // City Ambience Cue
    [SerializeField] private AudioCue ambienceCue;

    private void Start()
    {
        // Play a 2D looping ambience through AudioManager
        AudioManager.Instance.Play2D(ambienceCue);
    }
}
