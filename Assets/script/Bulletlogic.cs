

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletlogic : MonoBehaviour
{


    const float speed = 30.0f;
    const float lifetime=2.0f;


    Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfDestroy",lifetime);
        m_rigidbody = GetComponent<Rigidbody>();

    }
    void  Update() {
        transform.Translate(0,0,speed*Time.deltaTime);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Destructible")
        {
            // This destroy the other gameobject
            Destroy(other.gameObject);
            bodylogic.score++;

        }

        // this destroys the bullet
        Destroy(gameObject);
    }
    void selfDestroy(){
        Destroy(this.gameObject);
        }

}