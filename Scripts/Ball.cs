using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Manager manage;
    public Animator animation;
    public GameObject particleEffect;
    public GameObject stain;
    Vector3 stainCoordinate;
    public Rigidbody rigi;
    float jumpHeight = 5.0f;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Red_Cube")
        {
            animation.SetBool("Touched", true);
            Invoke("ResetAnimation", 0.5f);
            rigi.velocity = Vector3.up * jumpHeight;
            stainCoordinate = collision.contacts[0].point;

            GameObject newStain = Instantiate(stain, stainCoordinate, Quaternion.identity);
            newStain.transform.parent = collision.gameObject.transform;
            //GameObject newParticleEffect = Instantiate(particleEffect, stainCoordinate, Quaternion.identity);
            //Destroy(newParticleEffect, 1.0f);
        }

        if (collision.gameObject.tag == "Red_Cube")
        {
            manage.Again();
        }

        if (collision.gameObject.tag == "Floor")
        {
            manage.NextLevel();
        }
    }

    void ResetAnimation()
    {
        animation.SetBool("Touched", false); 
    }
}
