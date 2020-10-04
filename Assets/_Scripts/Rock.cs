using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float fallSpeed = 6f;
    SpriteRenderer SpriteRenderer;
    [SerializeField] Sprite[] sprites;

    private void OnEnable()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = sprites[Random.Range(0, 2)];
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * fallSpeed;
    }
}
