﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricleScript : MonoBehaviour
{
    Renderer m_Renderer;
    Rigidbody m_Rigidbody;
    public int threshold = 0;
    bool hasJumped = false;
    GameObject parentCube;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Rigidbody = GetComponent<Rigidbody>();
        parentCube = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateColor();

        if (parentCube.GetComponent<SquareScript>().shiftCount % 5 == threshold)
        {
            if (!hasJumped)
            {
                m_Rigidbody.AddForce(new Vector3(0f, 420f, 0f), ForceMode.Force);
                hasJumped = true;
            }
        }
        else
        {
            hasJumped = false;
        }
    }

    void UpdateColor()
    {
        m_Renderer.material.color = parentCube.GetComponent<SquareScript>().ReturnColor();
    }
}
