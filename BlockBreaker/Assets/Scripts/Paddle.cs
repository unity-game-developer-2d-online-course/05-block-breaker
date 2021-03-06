﻿using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float _minX = 1f;
    [SerializeField] private float _maxX = 15f;
    [SerializeField] private float _screenWidthInUnits = 16f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * _screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, _minX, _maxX);
        transform.position = paddlePos;
    }
}
