using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectCollision : MonoBehaviour
{

    public Rigidbody triggerBody; 
    public UnityEvent onTriggerEnter;

    public GameObject SpherePrefab; //to-do : essayer de le faire juste avec GameObject
    public Transform SphereOriginTransform; 

    
    

    void OnTriggerEnter(Collider other){
        //do not trigger if there's no trigger target object
        

        //only trigger if the triggerBody matches
        var hitRb = other.attachedRigidbody;
        if (other.CompareTag("ball")){
            onTriggerEnter.Invoke();
            // triggerBody.gameObject.transform.position = new Vector3(3.657522f, 2.35448f, -9.617743f);
            // triggerBody.velocity = Vector3.zero;
            Destroy(other.gameObject);
            
            GameObject newBall = Instantiate(SpherePrefab, SphereOriginTransform.position, SphereOriginTransform.rotation);
            Rigidbody SphereRigidBody = newBall.GetComponent<Rigidbody>();
        }
    }

}
