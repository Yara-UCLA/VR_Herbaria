using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    public Material _day;
    public Material _sunset;
    public Material _night;

    public GameObject _sunlight;
    public GameObject _sunsetlight;
    public GameObject _moonlight;


    public void Day()
    {
        RenderSettings.skybox = _day;
        _sunlight.SetActive(true);
        _sunsetlight.SetActive(false);
        _moonlight.SetActive(false);
    }

    public void Sunset()
    {
        RenderSettings.skybox = _sunset;
        _sunlight.SetActive(false);
        _sunsetlight.SetActive(true);
        _moonlight.SetActive(false);
    }

    public void Night()
    {
        RenderSettings.skybox = _night;
        _sunlight.SetActive(false);
        _sunsetlight.SetActive(false);
        _moonlight.SetActive(true);
    }


}
