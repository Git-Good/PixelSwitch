using UnityEngine;
using System.Collections;

public class CameraChangeColor : MonoBehaviour {
		//Get GameObjects
		public GameObject PlayerCamera;
		
		//Sky Colors
		public Color Black = Color.black;
		public Color Blue = Color.blue;
		public Color LightBlue = Color.blue;
		public Color DarkBlue = Color.blue;
		
		//Durations
		public float Duration1 = 6f;
		public float Duration2 = 80f;
		public float Duration3 = 40f;
		
		//Bools
		private bool Dawn;
		private bool Noon;
		private bool Dusk;
		private bool Midnight;
		
		//Time
		private float MinTime = 0.2f;
		private float MaxTime = 240f;
		public float CurrentTime;
		
		// Use this for initialization
		void Start () 
		{
			StartCoroutine(GameTimer());
		}
		
		// Update is called once per frame
		void Update () 
		{
			//Dawn
			if(CurrentTime > 0 && CurrentTime <= 60)
			{
				Dawn = true;
			}
			else
			{
				Dawn = false;
			}
			
			//Noon
			if(CurrentTime > 60 && CurrentTime <= 120)
			{
				Noon = true;
			}
			else
			{
				Noon = false;
			}
			
			//Dusk
			if(CurrentTime > 120 && CurrentTime <= 200)
			{
				Dusk = true;
			}
			else
			{
				Dusk = false;
			}
			
			//Midnight
			if(CurrentTime > 200 && CurrentTime <= 240)
			{
				Midnight = true;
			}
			else
			{
				Midnight = false;
			}
			
			AddjustCurrentTime(0);
			
			if(Dawn)
			{
				float t = Mathf.PingPong(Time.time, Duration1) / Duration1;
				PlayerCamera.GetComponent<Camera>().backgroundColor = Color.Lerp(Black, Blue, t);
			}
			
			if(Noon)
			{
				float t = Mathf.PingPong(Time.time, Duration1) / Duration1;
				PlayerCamera.GetComponent<Camera>().backgroundColor = Color.Lerp(Blue, LightBlue, t);
			}
			
			if(Dusk)
			{
				float t = Mathf.PingPong(Time.time, Duration2) / Duration2;
				PlayerCamera.GetComponent<Camera>().backgroundColor = Color.Lerp(LightBlue, DarkBlue, t);
			}
			
			if(Midnight)
			{
				float t = Mathf.PingPong(Time.time, Duration3) / Duration3;
				GetComponent<Camera>().backgroundColor = Color.Lerp(DarkBlue, Black, t);
			}
		}
		
		void CameraFlags() 
		{
			PlayerCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
		}
		

		public void AddjustCurrentTime(int adj)
		{
			CurrentTime += adj;
			
			if(CurrentTime < MinTime)
			{
				CurrentTime = MinTime;
			}
			
			if(CurrentTime >= MaxTime)
			{
				CurrentTime = MinTime;
			}
		}
		
		IEnumerator GameTimer()
		{
			while(true)
			{
				if(CurrentTime < MaxTime)
				{
					CurrentTime += 1f;
					yield return new WaitForSeconds(1f);
				}
				else
				{
					yield return null;
				}
				
			}
		}
}
