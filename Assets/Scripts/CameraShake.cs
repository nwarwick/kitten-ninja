using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public Camera playerCam;

    float shakeAmount = 0;

    // Use this for initialization
    void Awake()
    {
        if (playerCam == null)
        {
            playerCam = Camera.main;
        }
    }

    public void Shake(float amount, float length)
    {
        shakeAmount = amount;
        InvokeRepeating("StartShake", 0, .01f);
        Invoke("StopShake", length);
    }

    void StartShake()
    {
        if (shakeAmount > 0)
        {

            Vector3 playerCamPos = playerCam.transform.position;

            float offset = Random.value * shakeAmount * 2 - shakeAmount;
            //float shakeAmtX = Random.value * shakeAmount; // Could also try this
            //float offsetY = Random.value * shakeAmount * 2 - shakeAmount;

            playerCamPos.x += offset;
            playerCamPos.y += offset;
            //playerCamPos.z = 0f;

            playerCam.transform.position = playerCamPos;

        }
    }

    void StopShake()
    {
        CancelInvoke("StartShake");
        playerCam.transform.localPosition = Vector3.zero;

    }

}
