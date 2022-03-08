using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateslider : MonoBehaviour
{
    public GameObject objectToRotate;
    public Slider slider;

    private float previousValue;

    // Start is called before the first frame update
    void Start()
    {
        // Assign a callback for when this slider changes
        this.slider.onValueChanged.AddListener(this.rotate);

        // And current value
        this.previousValue = this.slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void rotate(float value) {


        float delta = value - this.previousValue;
        this.objectToRotate.transform.Rotate(Vector3.up * delta * 360);

        // Set our previous value for the next change
        this.previousValue = value;

    }
}
