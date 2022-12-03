using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    
    [SerializeField] private GameObject AirplaneBody;
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.TryGetComponent(out Entity entity))
        {
            
            entity.Die(this);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Entity entity))
        {

            entity.Die(this);

        }
    }

    public void Die()
    {
        Material newMat = Resources.Load("Red", typeof(Material)) as Material;
        AirplaneBody.GetComponent<Renderer>().material = newMat;
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}
