using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody prefabShell;
    public Transform ShellGenerator;

    public int playerNum = 1;
    string fireName;

    // Start is called before the first frame update
    void Start()
    {
        fireName = "Fire" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fireName)) // 스페이스 바
        {
            Fire();
        }

        if (Input.GetMouseButtonDown(0)) // 마우스 누르면 발사
        {
            Fire();
        }
    }

    public void Fire()
    {
        Rigidbody shellinstance = Instantiate(prefabShell, ShellGenerator.position, ShellGenerator.rotation);

        shellinstance.velocity = 20.0f * ShellGenerator.forward;
    }
}
