using UnityEngine;

namespace CompleteProject
{
	public class GameOverManager : MonoBehaviour
	{
		public PlayerHealth playerHealth;
		Animator anim;
		public float ShowScoresDelay;
		float ShowScoresTimer;
		public bool isGameOver;
		public bool isShow = false;
		void Awake()
		{
			anim = GetComponent<Animator>();
			ShowScoresDelay = 5;
			isGameOver = false;
		}


		void Update()
		{
			// If the player has run out of health...
			if(playerHealth.currentHealth <= 0) 
			{

				if (!isGameOver) {
					anim.SetTrigger ("GameOver");	

					isGameOver = true;
				}

				ShowScoresTimer += Time.deltaTime;
//				Debug.Log (isGameOver);
//				Debug.Log (ShowScoresTimer);
//				Debug.Log (ShowScoresDelay);
				if(ShowScoresTimer >= ShowScoresDelay)
				{
//					Debug.Log ("inter");
					isShow = true;
				}

			}
		}
	}

}