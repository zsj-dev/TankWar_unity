using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forkmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      RotatePlayerTowardsMouseCursor();
    }

    void RotatePlayerTowardsMouseCursor()
    {
        Vector2 mousePosInScreenSpace = Input.mousePosition;
        Vector2 playerPosInScreenSpace = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 directionInScreenSpace = mousePosInScreenSpace - playerPosInScreenSpace;

        float angle = Mathf.Atan2(directionInScreenSpace.y, directionInScreenSpace.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-angle + 90.0f, Vector3.up);
    }
}
