using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [field:SerializeField] public float JumpForce {  get; private set; }
    [field:SerializeField] public float rotationSpeed { get; private set; }
    [field:SerializeField] public float MovementSpeed { get; private set; } 

    public Rigidbody Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();

        if (TryGetComponent<Rigidbody>( out Rigidbody rb))
        {
            this.Rb = Rb;
        }
    }
}
