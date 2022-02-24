using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylogic : MonoBehaviour
{

    const float lifetime=8.0f;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfDestroy",lifetime);
    }
    void  Update() {
        
    }

    void selfDestroy(){
        Destroy(this.gameObject);
            }
}
