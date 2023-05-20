using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] float rotationOffset = 100f;

    Transform myT;
    Vector3 randomRotation;
    void Awake()
    {
        myT = transform;
    }

    void Start()
    {
        //random rotation
        randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
     }
    void Update ()
    {
        myT.Rotate(randomRotation * Time.deltaTime);
    }
}
