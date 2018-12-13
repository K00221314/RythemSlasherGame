using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class swordcutter : MonoBehaviour
{

    public Material capMaterial;
    private int count;
    public Text countText;



    public void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnCollisionEnter(Collision collision)
    {


        GameObject victim = collision.collider.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<MeshCollider>();
        //temp.convex = true;


        Destroy(pieces[1], 1);

        count = count + 1;
        SetCountText();
        
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        DontDestroyOnLoad(countText);
    }
}




