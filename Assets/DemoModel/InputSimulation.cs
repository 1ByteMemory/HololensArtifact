using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSimulation : MonoBehaviour
{
    public Image selectImage;

    public Sprite[] sprites; 


    // Start is called before the first frame update
    void Start()
    {
        selectImage.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            selectImage.sprite = sprites[1];
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            selectImage.sprite = sprites[0];
        }
    }
}
