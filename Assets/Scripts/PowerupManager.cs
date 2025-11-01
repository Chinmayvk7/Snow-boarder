using Unity.VisualScripting;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    [SerializeField] PowerupsSO powerup;
    PlayerController player;
    SpriteRenderer spriteRenderer;
    float timeLeft;


    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeLeft = powerup.GetTime();
    }

    void Update()
    {
        CountdownTimer();
    }

    void CountdownTimer()
    {
        if (spriteRenderer.enabled == false)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;

                if (timeLeft <= 0)
                {
                    player.DeactivatePowerup(powerup);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false;
            player.ActivatePowerup(powerup);
        }
    }
}
