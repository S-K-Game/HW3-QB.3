using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    [Tooltip("step size in meters")] [SerializeField] float stepSize = 2f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-stepSize * Time.deltaTime, 0, 0);
            animator.SetFloat("Speed", 1f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(stepSize * Time.deltaTime, 0, 0);
            animator.SetFloat("Speed", 1f);
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }
    }
    }
