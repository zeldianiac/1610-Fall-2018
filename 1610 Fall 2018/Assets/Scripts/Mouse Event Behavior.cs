using UnityEngine;
using UntiyEngine.Events;

public class MouseEventBehavior : MonoBehaviour
{
	
	public class MouseEventBehavior : MonoBehavior
	{
		public UnityEvent MouseDown;
		public UnityEvent MouseUp;
		

		private void OnMousDown()
		{
			MouseDown.invoke();
			
		}

		private void OnMouseUp()
		{
			MouseUp.Invoke();
		}
	}
}
