using UnityEngine;

public class Transporte : MonoBehaviour
{
    [SerializeField] private Transform destination;//[SerializeField] = permite que algo private seja visto no inspéctor e não deixnado outro código ascessá-lo


    public Transform GetDestination()
    {
        return destination;//retorna o valor do destino
    }
}
