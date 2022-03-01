
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylogic : MonoBehaviour
{

    const float lifetime=8.0f;

    float z_speed=1f;
    float x_speed=1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfDestroy",lifetime);
        InvokeRepeating("change_move",1f,1f);
    }
    void  Update() {
        float dz=z_speed*Time.deltaTime;
        float dx=x_speed*Time.deltaTime;
        this.transform.Translate(dx,0,dz,Space.Self);

        
    }
    void change_move(){
        float[] options={-1f,-0.5f,1f,0.5f};
        int sel=Random.Range(0,options.Length);
        z_speed=options[sel];
        x_speed=options[sel];



    }
    void selfDestroy(){
        Destroy(this.gameObject);
            }
}
