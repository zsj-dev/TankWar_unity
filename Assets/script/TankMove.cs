
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    [SerializeField]
    AudioClip movevoice;

    AudioSource m_audioSource;
    GameObject body;
    const float MOVEMENT_SPEED = 5.0f;

    float m_horizontalInput;
    float m_verticalInput;


    Vector3 moveDirection;
    Vector3 m_movement;

    Vector3 movelook;

    CharacterController m_characterController;

    // Start is called before the first frame update
    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
        m_audioSource = GetComponent<AudioSource>();
        body= GameObject.Find("body");
    }

    // Update is called once per frame
    void Update()
    {

        m_horizontalInput = Input.GetAxisRaw("Horizontal");
        m_verticalInput = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(m_horizontalInput, 0, m_verticalInput);

        body.transform.LookAt(body.transform.position+moveDirection);
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)){
            m_audioSource.PlayOneShot(movevoice);
        }

    
    }
    void FixedUpdate()
    {

        m_movement = moveDirection * MOVEMENT_SPEED * Time.deltaTime;
        m_characterController.Move(m_movement);
    }

}
