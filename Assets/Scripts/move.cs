using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float movementSpeed = 100;

    Transform myT;

    private void Awake()
    {
        myT = transform;
    }
    private void Update()
    {
        Thrust();
    }

    void Thrust()
    {
        myT.position += myT.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Horizontal");

    }
}
