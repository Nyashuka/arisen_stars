using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource _fireSound;

    private void Start()
    {
        _fireSound = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
    }
    
    public void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation).GetComponent<Damager>().SetDamage(100);
        _fireSound.Play();
    }
}

