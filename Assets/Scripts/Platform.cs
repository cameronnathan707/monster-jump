using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;

    public Transform cameraTransform;
    public Transform platformTransform;
    public AudioSource PlatformSound;
    const float CAMERA_B_EDGE = 4.57f;

    private void Start()
    {
        PlatformSound = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                if (!PlatformSound.isPlaying)
                {
                    PlatformSound.Play(0);
                }
            }
        }
    }

    void Update()
    {
        if (platformTransform.position.y < cameraTransform.position.y - CAMERA_B_EDGE)
        {
            Destroy(gameObject);
        }
    }
}