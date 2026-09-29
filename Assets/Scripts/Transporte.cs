using UnityEngine;

public class Transporte : MonoBehaviour
{
    [SerializeField] private Transform destination;


    public Transform GetDestination()
    {
        return destination;
    }
}
