
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bodylogic : MonoBehaviour
{

    public Text m_ammoText;
    
    static public int score=0;
    


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        m_ammoText.text = "Score: " + score;

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Destructible")
        {
            // This destroy the other gameobject
            Destroy(other.gameObject);
            score++;

        }
    }


}
