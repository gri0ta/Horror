using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;
    public AudioSource source;
    public float charge;

    void Update()
    {
        light.enabled = isOn;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }

        // TASK:
        // flashlight discharges when on
        // does not work when no energy

        // BONUS:
        // Reduce intensity or flicker light depending on charge
        // Show charge level visually

        // POST Flashlight.cs from github
    }

    void Switch()
    {
        isOn = !isOn;
        source.Play();
    }
}