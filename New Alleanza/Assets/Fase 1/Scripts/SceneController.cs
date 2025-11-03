using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    float alturaCam = 2;
    
    //[SerializeField] GameObject visao_cam;

    //bool piso_1 = false;
    //bool ponteCam = false;

    public void GoPraia()
    {
        SceneManager.LoadScene("Praia");
    }

    public void GoCasa()
    {
        SceneManager.LoadScene("MorganHouse");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.tag == "chao" && col.gameObject.tag == "Player")
        {
            Camera.main.transform.position = new Vector3(col.transform.position.x, col.transform.position.y + alturaCam, Camera.main.transform.position.z);
        }

        if (gameObject.tag == "ponte" && col.gameObject.tag == "Player")
        {
            Camera.main.transform.position = new Vector3(col.gameObject.transform.position., col.transform.position.y + alturaCam, Camera.main.transform.position.z);
        }
    }
    
    /*void VisaoCam ()
    {
        if (ponteCam)
        {
            Camera.main.transform.position = new Vector3(visao_cam.transform.position.x, visao_cam.transform.position.y, Camera.main.transform.position.z);
        }

        if (piso_1)
        {
            Camera.main.transform.position = new Vector3 ()
        }
    }*/
}