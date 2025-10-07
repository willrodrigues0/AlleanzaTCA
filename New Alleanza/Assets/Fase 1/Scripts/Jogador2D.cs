using UnityEngine;

public class Jogador2D : MonoBehaviour
{
    [SerializeField] float velocidade;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); //oxi??? Arrumar isso aqui
    }

    void FixedUpdate()
    {
        Mover();
    }

    void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
