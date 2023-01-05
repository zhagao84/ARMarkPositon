using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
public class SetUP : MonoBehaviour
{
    public PinchSlider pinchSlider;
    bool open;
    float lastvalue;
    public float multiple=0.001f;
    public void Run()
    {
        if (lastvalue < pinchSlider.SliderValue)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - pinchSlider.SliderValue *multiple, transform.position.z);
            lastvalue = pinchSlider.SliderValue;
        }

        else if (lastvalue>pinchSlider.SliderValue) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + pinchSlider.SliderValue * multiple, transform.position.z);
            lastvalue=pinchSlider.SliderValue;
        }
          
    }

    //public void Open(bool state)
    //{
    //    open = state;
    //}
}
