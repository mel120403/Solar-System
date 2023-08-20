using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    //declare a ga,e object variable which defines the target where the camera should look at
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target= this.gameObject;
            Debug.Log("change target is not specified. deaulting to parent object");
        }
    }

    // Update is called once per frame
    private void OnMouseDown(){
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x,1, 100);
    }
}
