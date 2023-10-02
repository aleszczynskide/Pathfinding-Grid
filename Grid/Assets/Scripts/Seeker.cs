using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Seeker : MonoBehaviour
{
    Rigidbody2D Rb;
    Animator Anim;
    public Vector3 Target;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();   
        Anim = GetComponent<Animator>();    
    }
    private void Update()
    {
        var direction = (Target - this.transform.position).normalized;
        Anim.SetFloat("Horizontal",direction.x);
        Anim.SetFloat("Vertical", direction.y);
    }
}
