using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // declaring a variable to select the rotation target 
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Roatate around the first paramter is target position
        // needs second parametrer for rotation.
        // parametr needed is the speed of rotation 
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime  );           
    }
}
