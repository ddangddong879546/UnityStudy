using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        print("�浹 Enter : " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("�浹 Exit : " + collision.gameObject.name);
    }
}
