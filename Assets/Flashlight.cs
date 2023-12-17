using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;
    public AudioSource source;

    // ADD flashlight, background, walk sounds

    // TASK : make flashlight battery powered. energy level decreases on use.
    // when battery low it blinks or fades. When no charge left it dies.


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;
            source.Play();
        }

        light.enabled = isOn;
    }
}