using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class limit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("b_01") ||
            collision.CompareTag("b_02") ||
            collision.CompareTag("b_03") ||
            collision.CompareTag("b_04") ||
            collision.CompareTag("b_05") ||
            collision.CompareTag("b_06") ||
            collision.CompareTag("b_07") ||
            collision.CompareTag("b_08") ||
            collision.CompareTag("b_09") ||
            collision.CompareTag("b_10") ||
            collision.CompareTag("b_11") ||
            collision.CompareTag("b_12"))
        {
            SceneManager.LoadScene("over");
        }
    }

}
