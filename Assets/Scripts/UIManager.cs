using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Slider sanitySlider;
    public Slider healthSlider;
    public Slider lightSlider;

    public void SetSanity(int sanity)
    {
        sanitySlider.value = sanity;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    public void SetLight(int light)
    {
        lightSlider.value = light;
    }

}
