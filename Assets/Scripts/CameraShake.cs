using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = 1f;
    [SerializeField] float shakeMagnitue = 0.5f;

    Vector3 initPos;

    void Start()
    {
        initPos = transform.position;
    }

    public void Play()
    {
        StartCoroutine(ScreenShake());
    }

    IEnumerator ScreenShake()
    {
        float elapsedTime = 0;
        while (elapsedTime < shakeDuration)
        {
            transform.position = initPos + (Vector3)Random.insideUnitCircle * shakeMagnitue;
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = initPos;
    }

}
