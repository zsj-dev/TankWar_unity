using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunLogic : MonoBehaviour
{
    [SerializeField]
    GameObject m_bulletPrefab;

    [SerializeField]
    Transform m_bulletSpawnPoint;
    [SerializeField]
    AudioClip Shot;
    [SerializeField]
    AudioClip noshot;
    [SerializeField]
    AudioClip changebullet;

    [SerializeField]
    Text bulletstate;


    AudioSource m_audioSource;

    bool fire=true;

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        // Apply cooldown


        if(Input.GetButton("Fire1") )
        {
            if(fire){
                Shoot();
            }else{
                m_audioSource.PlayOneShot(noshot);


            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
            m_audioSource.PlayOneShot(changebullet);
        }



    }

    void Shoot()
    {


        Instantiate(m_bulletPrefab, m_bulletSpawnPoint.position, m_bulletSpawnPoint.rotation);
        m_audioSource.PlayOneShot(Shot);
        fire=false;
        bulletstate.text="Empty";

    }
    void Reload(){
        fire=true;
        bulletstate.text="Fire!!!";
    }



}