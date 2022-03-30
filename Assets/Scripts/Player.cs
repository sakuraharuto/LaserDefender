using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    Vector2 rawInput;
    [SerializeField] float moveSpeed = 5f;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }

    void OnMove(InputValue value){
       rawInput = value.Get<Vector2>();
       Debug.Log(rawInput);
    }
}
