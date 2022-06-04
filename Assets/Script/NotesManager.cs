using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    [Header("—¬‚ê‚é‘¬“x")]
    [SerializeField]
    float Speed;

    [Header("‚à‚ç‚¦‚é“¾“_")]
    [SerializeField]
    int Score;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
    }
}
