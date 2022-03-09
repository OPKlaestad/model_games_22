using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseInteraction : MonoBehaviour
{
    private float checker = 0;
    public float pushForce = 5;

    public Transform protagonist; 
    // Update is called once per frame
    void Start(){
        //this.transform.position = new Vector3(protagonist.position.x ,protagonist.position.y ,protagonist.position.z-10);
    }

    void Update()
    {
        //this.transform.position = new Vector3(protagonist.position.x ,protagonist.position.y ,protagonist.position.z-10);
        RaycastHit hit; //raycast variable with info about the hit

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); //returns the ray sent from mousePosition
    if(Input.GetMouseButtonDown(0)){
        if(Physics.Raycast(ray, out hit) && hit.rigidbody != null){
            hit.rigidbody.AddForce(new Vector3(0, pushForce, 0), ForceMode.Impulse);
            
        }
        else if(hit.rigidbody == null){
            
        }
    }
    }
}
