using UnityEngine;
using UnityEngine.SceneManagement;
 

public class Jugador3 : MonoBehaviour
{
   [SerializeField] GameObject player;
   [SerializeField] GameObject checkPoint;
   [SerializeField] Vector3 vectorPoint;
   [SerializeField] float dead;

   private new Rigidbody _rigidbody;
   public float jumpspeed;
   public float speed;
   private float _distanceToGround;
   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody>();
      _distanceToGround = GetComponent<Collider>().bounds.extents.y;
      vectorPoint = player.transform.position;
   }

   private void UpdateMovement()
   {
      float hor = Input.GetAxis("Horizontal");
      float ver = Input.GetAxis("Vertical");
      //Vector3 velocity;
      if (hor != 0 || ver != 0)
      {
         transform.Rotate(0,  hor * Time.deltaTime * 200f,0);
         transform.Translate(0,0,ver*Time.deltaTime * speed);
      }
      /*else
      {
         velocity=Vector3.zero;
      }

      velocity.y = rigidbody.velocity.y;
      rigidbody.velocity = velocity;*/
   }

   private void UpdateJump()
   {
      if (Input.GetButtonDown("Jump") && IsGrounded())
      {
         _rigidbody.AddForce(Vector3.up*jumpspeed, ForceMode.Impulse);
      }
   }

   private bool IsGrounded()
   {
      return Physics.BoxCast(transform.position, new Vector3(0.4f, 0f, 0.4f), Vector3.down, Quaternion.identity, _distanceToGround+0.1f );
   }
   private void Update()
   {
      UpdateMovement();
      UpdateJump();
      if (player.transform.position.y < dead)
      {
         player.transform.position = vectorPoint;
      }
   }

   private void OnTriggerEnter(Collider collider)
   {
      if (collider.gameObject.tag == ("Objetivo"))
      {
         GameManager.Instance.inmunidad+=1;
         SceneManager.LoadScene("LugarPortales");
      }
   }
}
