using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip coinCollectAudio;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void OnEnable()
    {
        PlayerMovement.OnCoinCollected += PlayerMovement_OncoinCollected;
    }

    private void PlayerMovement_OncoinCollected()
    {
        audioSource.clip = coinCollectAudio;
        audioSource.Play();
    }

    private void OnDisable()
    {
        PlayerMovement.OnCoinCollected -= PlayerMovement_OncoinCollected;
    }
}
