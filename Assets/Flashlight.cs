using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;

    void Update()
    {
        light.enabled = isOn;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }
    }

    void Switch()
    {
        isOn = !isOn;
        // switch, Ambient(Background), footstep sounds
    }
}