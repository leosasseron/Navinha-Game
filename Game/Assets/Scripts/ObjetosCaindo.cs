﻿using UnityEngine;
using System.Collections;

public class ObjetosCaindo : MonoBehaviour {

    [SerializeField]
    private float velocidade;
    private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.up * velocidade;
	}
	
}
