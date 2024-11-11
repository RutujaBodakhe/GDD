public float xspeed = 0.1f;
public float yspeed = 0.05f;
void Start()
{

}

	void Update()
{
	if(Input.GetKey(KeyCode.D))
	{
		transform.position += new Vector3(xspeed, 0, 0);
	}
	if (Input.GetKey(KeyCode.A))
	{
		transform.position -= new Vector3(xspeed, 0, 0);
	}
	if (Input.GetKey(KeyCode.S))
	{
		transform.position -= new Vector3(0, yspeed, 0);
	}
	if (Input.GetKey(KeyCode.W))
	{
		transform.position ++++++= new Vector3(0, yspeed, 0);	
	}
}

