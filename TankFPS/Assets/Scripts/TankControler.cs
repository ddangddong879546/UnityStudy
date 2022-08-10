using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControler : MonoBehaviour
{
    float mvSpeed = 10.0f;
    float roSpeed = 150.0f;

    public int playerNum = 1;
    string mvAxisName;
    string roAxisName;

    private Quaternion mTankTargetRot;
    private Quaternion mCameraTargetRot;
    private Camera mCamera;

    // Start is called before the first frame update
    void Start()
    {
        mvAxisName = "Vertical" + playerNum;
        roAxisName = "Horizontal" + playerNum;

        mCamera = Camera.main;
        mTankTargetRot = transform.localRotation;
        mCameraTargetRot = mCamera.transform.localRotation;

    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("Mouse X");
        float yRot = Input.GetAxis("Mouse Y");

        mTankTargetRot *= Quaternion.Euler(-yRot, xRot, 0f);
        transform.localRotation = mTankTargetRot;

        //mCameraTargetRot *= Quaternion.Euler(-yRot, 0f, 0f);
        //mCamera.transform.localRotation = mCameraTargetRot;


        float vmv = Input.GetAxis(mvAxisName);
        float hmv = Input.GetAxis(roAxisName);

        Vector2 vec2 = new Vector2(-hmv, -vmv);
        Vector3 move = transform.forward * -1 * vec2.y + transform.right * -1 * vec2.x;
        transform.position += move * mvSpeed * Time.deltaTime;

    }
}
