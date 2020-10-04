using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float fallSpeed = 6f;
    SpriteRenderer SpriteRenderer;
    [SerializeField] Sprite[] sprites;
    bool paused = false;

    private void OnEnable()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = sprites[Random.Range(0, 2)];
    }


    // Update is called once per frame
    void Update()
    {
        if (paused) return;
        transform.position += -transform.up * Time.deltaTime * fallSpeed;
    }

    public void TogglePause()
    {
        if (paused)
        {
            paused = false;
        }
        else
        {
            paused = true;
        }
    }
}
