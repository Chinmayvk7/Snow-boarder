using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] ParticleSystem powerupParticles;
    bool canMove = true;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    float previousRotation;
    float totalRotation;
    ScoreManager scoreManager;
    int activePowerupCount;


    [System.Obsolete]
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }


    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
            CalculateFlips();
        }
    }

    void CalculateFlips()
    {
        float currentRotation = transform.rotation.eulerAngles.z;
        totalRotation += Mathf.DeltaAngle(previousRotation, currentRotation);
        if(totalRotation > 340 || totalRotation < -340)
        {
   
            totalRotation = 0;
            scoreManager.AddScore(100);
        }
        previousRotation = currentRotation;
    }


    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }

        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    public void ActivatePowerup(PowerupsSO powerup)
    {
        powerupParticles.Play();
        activePowerupCount += 1;
        if (powerup.GetPowerupType() == "speed")
        {
            baseSpeed += powerup.GetValueChange();
            boostSpeed += powerup.GetValueChange();
        }

        else if (powerup.GetPowerupType() == "torque")
        {
            torqueAmount += powerup.GetValueChange();
        }
    }
    
    public void DeactivatePowerup(PowerupsSO powerup)
    {
        activePowerupCount -= 1;
                
        if(activePowerupCount==0)
        {
            powerupParticles.Stop();
        }
        if (powerup.GetPowerupType() == "speed")
        {
            baseSpeed -= powerup.GetValueChange();
            boostSpeed -= powerup.GetValueChange();
        }

        else if (powerup.GetPowerupType() == "torque")
        {
            torqueAmount -= powerup.GetValueChange();
        }
    }
}
