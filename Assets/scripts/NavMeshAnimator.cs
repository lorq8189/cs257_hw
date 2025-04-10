using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.AI.NavMeshAgent navMesh;
    private Animator animator;

    void Awake()
    {
        navMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocity", navMesh.velocity.magnitude);
    }
}
