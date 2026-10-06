using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class alavanca : MonoBehaviour
{
    public GameObject Alavanca;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Alavanca != null)
            {
                Alavanca.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("alavanca"))
        {
            Alavanca = null;
        }
    }
}
