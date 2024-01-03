using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public int pages;
    public Enemy enemy;

    void OnTriggerEnter(Collider other)
    {
        print("You found a page!");
        Destroy(other.gameObject);
        pages++;

        if (pages == 1)
        {
            enemy.target = transform;
        }
    }

    
}
