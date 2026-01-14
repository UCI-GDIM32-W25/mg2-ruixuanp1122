using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Jump Settings")]
    [SerializeField] private float _jumpForce = 8f;
    [Header("Ground Check")]
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask _groundLayer;
    // Start is called before the first frame update
   private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
