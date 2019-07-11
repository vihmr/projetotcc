using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public GameObject lanterna1;

    // Start is called before the first frame update
    void Start()
    {
        lanterna1.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Lanternas"))
        {
            Destroy(collision2D.gameObject);
            lanterna1.SetActive(true);
        }
    }
}
