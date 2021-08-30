using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController character;
    [SerializeField]
    private float playerSpeed;
    private float gravity = 9.81f;
    [SerializeField]
    private GameObject muzzleflashPrefab;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();

    }

    private void Movement()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * playerSpeed;
        velocity.y -= gravity;
        velocity = transform.transform.TransformDirection(velocity);
        character.Move(velocity * Time.deltaTime);
    }

    public void Shoot()
    {
        if (Input.GetMouseButton(0))
        {
            muzzleflashPrefab.SetActive(true);
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("RAycast hit" + hit.transform.name);
            }


        }
        else
        {
            muzzleflashPrefab.SetActive(false);
        }
    }
}

//CharacterController character;
//[SerializeField] float playerSpeed;
//float gravity = 9.8f;
//[SerializeField] ParticleSystem muzzleFlashPrefab;
//[SerializeField] GameObject hitMarkerPrefab;
//AudioSource audioSource;
//[SerializeField] AudioClip shootAudio;
//[SerializeField] Transform firePosition;
//[SerializeField]float fireRate = 1f;
//// Start is called before the first frame update
//void Start()
//{
//    character = GetComponent<CharacterController>();
//    audioSource = GetComponent<AudioSource>();
//}

//// Update is called once per frame
//void Update()
//{
//    Movement();
//    FireGun();
//}
//public void Movement()
//{
//    Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//    Vector3 velocity = direction * playerSpeed;
//    velocity.y -= gravity;
//    character.Move(velocity * Time.deltaTime);
//}
//public void FireGun()
//{
//    fireRate -= Time.deltaTime;
//    if (Input.GetMouseButtonDown(0) && fireRate <= 0)
//    {

//        if (BulletPooling.bulletIstance.bulletCount <= 50)
//        {
//            BulletPooling.bulletIstance.BulletSpawn();
//            fireRate = 1f;
//            audioSource.clip = shootAudio;
//            audioSource.Play();
//            if (Input.GetKeyDown(KeyCode.Q))
//            {
//                BulletPooling.bulletIstance.bulletCount = 50;
//            }
//        }

//        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
//        RaycastHit hit;
//        //Debug.Log(Physics.Raycast(ray,out hit, Mathf.Infinity));
//        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
//        {
//            //Debug.Log("Raycast hit");
//            //GameObject temp=Instantiate(hitMarkerPrefab, hit.point, Quaternion.identity);
//            //Destroy(temp, 1f);
//            GameObject effect = Pooling.instance.GetPoolObject("HitMarker");
//            if (effect != null && hit.collider.gameObject.tag != "Bullet")
//            {
//                effect.transform.position = hit.point;
//                effect.SetActive(true);
//                StartCoroutine(HitMarkerInActive(effect));
//            }
//        }
//        else
//        {

//            muzzleFlashPrefab.Play();
//            StartCoroutine(ParticleStop());
//        }
//    }
//}
//IEnumerator ParticleStop()
//{
//    yield return new WaitForSeconds(1);
//    muzzleFlashPrefab.Stop();
//}
//IEnumerator HitMarkerInActive(GameObject effect)
//{
//    yield return new WaitForSeconds(1);
//    effect.SetActive(false);
//}
//}
