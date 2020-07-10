using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour
{

    private AudioSource audioScore;

    public AudioClip point;
    public AudioClip hit;

    private void OnEnable()
    {

        CollidersInterations.deadZoneCollider += playerDead;
        IncressPoint.incressPoint += ScoreUp;
        
    }

    private void OnDisable()
    {

        CollidersInterations.deadZoneCollider -= playerDead;
        IncressPoint.incressPoint -= ScoreUp;

    }

    void ScoreUp()
    {

        audioScore.pitch = 1;
        audioScore.PlayOneShot(point);

    }

    void playerDead()
    {

        audioScore.pitch = 1.8f;
        audioScore.PlayOneShot(hit);


    }

    // Start is called before the first frame update
    void Start()
    {

        audioScore = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
