using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public AudioClip scaryMusic;
    public FirstPersonMovement speed2;

    void OnTriggerEnter(Collider other)
    {
        print("You found a page!");
        Destroy(other.gameObject);
        pages++;

        if (pages == 1)
        {
            //enemy wake up
            enemy.target = transform;
        }

        if (pages ==2)
        {
            //speed enemy 2x
            enemy.speed *= 2;
        }
        if (pages == 3)
        {
            enemy.viewDistance += 20;
        }

        if (pages == 4)
        {
            var source = GetComponent<AudioSource>();
            source.clip = scaryMusic;
            source.Play();
        }

        if (pages ==5)
        {
            speed2.speed -= 2;
        }
    }

    
}
