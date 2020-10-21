using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Explodable))]

public class Destroy : MonoBehaviour
{
    private Explodable _explodable;
    public AudioSource noise1;
    public AudioSource[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        _explodable = GetComponent<Explodable>();
        AudioSource[] sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        _explodable.explode();
        ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        ef.doExplosion(transform.position);
        noise1.Play();
    }
}
