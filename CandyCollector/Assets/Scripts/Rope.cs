using UnityEngine;

public class Rope : MonoBehaviour {

	public Rigidbody2D hook;

	public GameObject linkPrefab;

	public Weight weigth;

	public int links = 7;

	void Start () {
		GenerateRope();
	}

    private void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			Debug.Log(hit.collider);
			if(hit.collider.tag == "Rope" && hit.collider != null)
            {
				this.transform.position = mousePos2D;
            }
		}
	}

    void GenerateRope ()
	{
		Rigidbody2D previousRB = hook;
		for (int i = 0; i < links; i++)
		{
			GameObject link = Instantiate(linkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
			joint.connectedBody = previousRB;

			if (i < links - 1)
			{
				previousRB = link.GetComponent<Rigidbody2D>();
			} else
			{
				weigth.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
			}

			
		}
	}

}
