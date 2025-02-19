using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalController : MonoBehaviour
{
    [SerializeField] protected GameObject effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        effect.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        effect.SetActive(false);
    }
}
