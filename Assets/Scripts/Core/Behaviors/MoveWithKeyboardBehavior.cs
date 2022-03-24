using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Input Keys
public enum InputKeyboard{
    arrows =1, 
    wasd = 0
}
public class MoveWithKeyboardBehavior : AgentBehaviour
{
    public InputKeyboard inputKeyboard;

    
    
    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        //implement your code here
      if(inputKeyboard == InputKeyboard.wasd)
        {
            float horizontal = Input.GetAxis("HorizontalWASD");
            float vertical = Input.GetAxis("VerticalWASD");
            steering.linear = new Vector3(horizontal, 0, vertical) * agent.maxAccel;
            steering.linear = this.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear, agent.maxAccel));
        }
      if(inputKeyboard == InputKeyboard.arrows)
        {
            float horizontal = Input.GetAxis("HorizontalARROWS");
            float vertical = Input.GetAxis("VerticalARROWS");
            steering.linear = new Vector3(horizontal, 0, vertical) * agent.maxAccel;
            steering.linear = this.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear, agent.maxAccel));
        }
          
         
        
        return steering;
    }

}
