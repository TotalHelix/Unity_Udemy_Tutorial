using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{

    [SerializeField] float x_speed;
    [SerializeField] float y_speed;
    [SerializeField] float z_speed;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x_speed, y_speed, z_speed);
    }
}
