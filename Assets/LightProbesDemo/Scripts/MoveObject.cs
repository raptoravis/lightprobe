using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Transform CubeTransform;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        CubeTransform = GameObject.Find("Cube").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            CubeTransform.Translate(CubeTransform.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            CubeTransform.Translate(CubeTransform.forward * -1 * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            CubeTransform.Translate(CubeTransform.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            CubeTransform.Translate(CubeTransform.right * -1 * Time.deltaTime * speed);
        }
    }
}
