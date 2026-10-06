using UnityEditor.Search;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float suavidade = 10f;
    public Vector3 offset;



    private void LateUpdate()
    {
        Vector3 positionA = target.position + offset;
        Vector3 positionSmooth = Vector3.Lerp(transform.position, positionA, suavidade);
        transform.position = positionSmooth;

    }


}

