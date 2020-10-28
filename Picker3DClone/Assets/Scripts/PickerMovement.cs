using UnityEngine;

public class PickerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Transform finish_box;
    public GameManager gameManager;
    public ScoreController sc;

    public float zforce = 4000f;
    public float xforce = 165f;
    public float delay = 1f;
    public float mPosition;
    public float ScreenWidth;
    




    public void Start()
    {
        float xPosition = transform.position.x;
        float yPosition = transform.position.y;
        ScreenWidth = Screen.width;
        

    }
    
   

    void FixedUpdate()
    {
        if( transform.position.z < finish_box.position.z - 13)
        {
            rb.AddForce(0, 0, zforce * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            //if (Input.GetMouseButtonDown(0))
            //{
            //    //Debug.Log("Mouse basıldı");

            //    mPosition = Input.mousePosition.x;

            //    transform.position. = 
            //    //transform.position = Vector3.Lerp(transform.position, mPosition, Time.deltaTime * 50);
            //}
            mPosition = Input.mousePosition.x;
            //Debug.Log("MouseX" + mPosition);
            //Debug.Log("Screeen" + ScreenWidth / 2);

            if (Input.GetMouseButton(0))
            {
                if (mPosition > ScreenWidth/2)
                {
                    rb.AddForce(xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }

                if (mPosition < ScreenWidth / 2)
                {
                    rb.AddForce(-xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                
            }


        }
        else
        {
            Invoke("deciderThis", delay);
        }
        
        if (transform.position.x > 12 || transform.position.x < -13)
        {
            //FindObjectOfType<GameManager>().restart();
            gameManager.restart();
        }

    }

    public void deciderThis()
    {
        sc.Decider();
    }


}
