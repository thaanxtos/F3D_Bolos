using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_Bola : MonoBehaviour
{
    [SerializeField] GameObject director;
    
    void Start()
    {

    }

    
    void Update()
    {
        LaunchBall();
        RotateLeft();
        RotateRight();
    }

    private void LaunchBall()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(director.transform.forward * 500);
        }
    }

    private void RotateLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            director.transform.eulerAngles += new Vector3(0, -10 * Time.deltaTime, 0);
        }
    }

    private void RotateRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            director.transform.eulerAngles += new Vector3(0, 10 * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collider"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Bowling");
        }
    }
}
