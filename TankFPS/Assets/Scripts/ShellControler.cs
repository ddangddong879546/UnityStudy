using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellControler : MonoBehaviour
{
    public ParticleSystem shellExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // 어떤 물체를 맞으면 터지는 현상
    {
        ParticleSystem fire = Instantiate(shellExplosion, transform.position, transform.rotation);
        fire.Play();

        Destroy(gameObject);
        Destroy(fire.gameObject, 2.0f);
    }

}
