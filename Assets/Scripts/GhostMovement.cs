using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostMovement : MonoBehaviour
{

	public Transform[] waypoints;


	public float moveSpeed = 1f;

	public GameObject button;

	private int waypointIndex = 0;

	private AudioSource audioData;

	
	void Start()
	{
		audioData = GetComponent<AudioSource>();
		transform.position = waypoints[waypointIndex].transform.position;
	}

	void Update()
	{
		Move();
	}

	void Move()
	{
		transform.position = Vector3.MoveTowards(transform.position,
												waypoints[waypointIndex].transform.position,
												moveSpeed * Time.deltaTime);

		if (transform.position == waypoints[waypointIndex].transform.position)
		{
			waypointIndex += 1;
		}

		if (waypointIndex == waypoints.Length)
			waypointIndex = 0;
	}

	void OnTriggerEnter2D(Collider2D co)
	{
		if (co.name == "Pacman")
		{
			audioData.Play();
			Destroy(co.gameObject);
			Time.timeScale = 0;
			button.SetActive(true);

		}
	}

	public void GameOver()
    {
		button.SetActive(false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


		
	

}
