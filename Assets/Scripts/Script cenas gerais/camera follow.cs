using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform alvo; //para câmera, trabalhamos junto com o alvo
    public Vector3 distancia = new Vector3(0f, 0f, -10f);//alterar a distancia de layer para a câmera não ficar na mesma camada do player
    public bool movimentoSuave = true;
    public float velocidade = 5f;

    private void LateUpdate() //rodando na mesma quantidade de fps do pc, mas roda todos os scripts antes dele
    {
        Vector3 posicaoDesejada = alvo.position + distancia;// posiçãoDesejada = variável que guarda a posição. alvo.position = colocoa o player e pega distancia e soma com a distância.

        if (movimentoSuave)
        {
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime);
            //lerp = gera interpolações na posição Ex: sem p1 = p2. com p1 = p1.9 = p2
        }
        else
        {
            transform.position += posicaoDesejada;
        }
    }


}
