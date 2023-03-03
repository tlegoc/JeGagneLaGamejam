using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed = 5;
    private bool isColliding = false;

    public AudioSource audioSource;
    public AudioClip jumpSound;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump") && isColliding) {
            Debug.Log("Oui");

            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
            audioSource.PlayOneShot(jumpSound);
        }
    }

    // Peut poser des problèmes quand on entre/sort dans plusieurs objets en même temps
    private void OnTriggerEnter(Collider other) {
        isColliding = true;
    }

    private void OnTriggerExit(Collider other) {
        isColliding = false;
    }
}
