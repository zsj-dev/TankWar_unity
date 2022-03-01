
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycreate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject enemy;

    void Start()
    {
        InvokeRepeating("Crate_enemy",0.1f,2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Crate_enemy(){
        GameObject node=Instantiate(enemy,this.transform);
        node.transform.position=this.transform.position;
        float dx=Random.Range(-10,10);
        float dz=Random.Range(-10,10);
        node.transform.Translate(dx,0,dz,Space.Self);
        
    }

}
